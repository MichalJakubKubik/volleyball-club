using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApplication.Entities;
using MyApplication.Exceptions;
using MyApplication.Models;
using System.Linq.Expressions;

namespace MyApplication.Services
{
    public interface IClubService
    {
        PagedResult<ClubDto> GetAllClubs(ClubQuery query);
        ClubDto GetClub(int id);
        int CreateClub(CreateClubDto dto);
        void DeleteClub(int id);
        void UpdateClub(int id, CreateClubDto dto);
        IEnumerable<ClubDto> GetClubsByLeague(int leagueNumber);
    }

    public class ClubService : IClubService
    {
        private readonly IMapper _mapper;
        private readonly ClubDbContext _dbContext;
        private readonly ILogger<ClubService> _logger;

        public ClubService(ClubDbContext dbContext, IMapper mapper, ILogger<ClubService> logger)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _logger = logger;
        }
        public PagedResult<ClubDto> GetAllClubs(ClubQuery query)
        {
            var baseQuery = _dbContext.Clubs
                .Include(c => c.ClubAddress)
                .Include(c => c.LeagueLevel)
                .Include(c => c.Players).ThenInclude(c => c.PlayerPosition)
                .Include(c => c.Coaches).ThenInclude(c => c.CoachOccupation)
                .Where(c => query.SearchPhrase == null || (c.ShortName.ToLower().Contains(query.SearchPhrase.ToLower())
                                                            || c.FullName.ToLower().Contains(query.SearchPhrase.ToLower())
                                                            || c.ContactEmail.ToLower().Contains(query.SearchPhrase.ToLower())
                                                            || c.ContactNumber.ToLower().Contains(query.SearchPhrase.ToLower())));

            if (!baseQuery.Any())
                throw new NotFoundException("Clubs not found");

            if (!string.IsNullOrEmpty(query.SortBy))
            {
                var columnsSelector = new Dictionary<string, Expression<Func<Club, object>>>()
                {
                    { nameof(Club.ShortName), r => r.ShortName},
                    { nameof(Club.FullName), r => r.FullName}
                };

                var selectedColumn = columnsSelector[query.SortBy];

                baseQuery = query.SortDirection == SortDirection.ASC 
                    ? baseQuery.OrderBy(selectedColumn) 
                    : baseQuery.OrderByDescending(selectedColumn);
            }

            var clubs = baseQuery
                .Skip(query.PageSize * (query.PageNumber - 1))
                .Take(query.PageSize)
                .ToList();

            var totalItemsCount = baseQuery.Count();

            var clubsDtos = _mapper.Map<List<ClubDto>>(clubs);

            var result = new PagedResult<ClubDto>(clubsDtos, totalItemsCount, query.PageSize, query.PageNumber);

            return result;
        }
        public ClubDto GetClub(int id)
        {
            var club = _dbContext.Clubs
                .Include(c => c.ClubAddress)
                .Include(c => c.LeagueLevel)
                .Include(c => c.Players).ThenInclude(c => c.PlayerPosition)
                .Include(c => c.Coaches).ThenInclude(c => c.CoachOccupation)
                .FirstOrDefault(c => c.Id == id);

            if (club is null)
                throw new NotFoundException("Club not found");

            var result = _mapper.Map<ClubDto>(club);

            return result;
        }

        public IEnumerable<ClubDto> GetClubsByLeague(int leagueNumber)
        {
            var clubs = _dbContext.Clubs
                .Include(c => c.ClubAddress)
                .Include(c => c.LeagueLevel)
                .Include(c => c.Players).ThenInclude(c => c.PlayerPosition)
                .Include(c => c.Coaches).ThenInclude(c => c.CoachOccupation)
                .Where(c => c.LeagueLevelId == leagueNumber)
                .ToList();

            if (!clubs.Any())
                throw new NotFoundException("Clubs not found");

            var result = _mapper.Map<List<ClubDto>>(clubs);

            return result;
        }

        public void DeleteClub(int id)
        {
            _logger.LogWarning($"Club with Id: {id} DELETE action invoked");

            var club = _dbContext.Clubs
                .FirstOrDefault(c => c.Id == id);

            if (club == null)
                throw new NotFoundException("Club not found");

            _dbContext.Clubs.Remove(club);
            _dbContext.SaveChanges();
        }

        public int CreateClub(CreateClubDto dto)
        {
            var ligueLevel = _dbContext.LeagueLevels.FirstOrDefault(l => l.LeagueName == dto.LeagueName);
            var club = _mapper.Map<Club>(dto);
            club.LeagueLevel = ligueLevel;
            _dbContext.Clubs.Add(club);
            _dbContext.SaveChanges();

            return club.Id;
        }

        public void UpdateClub(int id, CreateClubDto dto)
        {
            var club = _dbContext.Clubs
                .Include(c => c.ClubAddress)
                .Include(c => c.LeagueLevel)
                .FirstOrDefault(c => c.Id == id);

            if (club is null)
                throw new NotFoundException("Club not found");

            var ligueLevel = _dbContext.LeagueLevels.FirstOrDefault(l => l.LeagueName == dto.LeagueName);

            if (ligueLevel is null)
                throw new NotFoundException("League not found");

            club.ShortName = dto.ShortName;
            club.FullName = dto.FullName;
            club.ContactEmail = dto.ContactEmail;
            club.ContactNumber = dto.ContactNumber;
            club.ClubAddress.City = dto.City;
            club.ClubAddress.PostalCode = dto.PostalCode;
            club.ClubAddress.Street = dto.Street;
            club.LeagueLevel = ligueLevel;

            _dbContext.SaveChanges();
        }
    }
}
