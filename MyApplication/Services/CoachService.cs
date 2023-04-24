using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MyApplication.Authorization;
using MyApplication.Entities;
using MyApplication.Exceptions;
using MyApplication.Models;
using System.Numerics;
using System.Security.Claims;

namespace MyApplication.Services
{
    public interface ICoachService
    {
        CoachDto GetCoach(int Id);
        IEnumerable<CoachDto> GetAllCoachesFromClub(int clubId);
        int CreateCoach(CreateCoachDto dto);
        void DeleteCoach(int id);
        void UpdateCoach(int Id, CreateCoachDto dto);
    }

    public class CoacheService : ICoachService
    {
        private readonly IMapper _mapper;
        private readonly ClubDbContext _dbContext;
        private readonly ILogger<ClubService> _logger;
        private readonly IAuthorizationService _authorizationService;
        private readonly IUserContextService _userContextService;

        public CoacheService(ClubDbContext dbContext, IMapper mapper, ILogger<ClubService> logger, IAuthorizationService authorizationService, IUserContextService userContextService)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _logger = logger;
            _authorizationService = authorizationService;
            _userContextService = userContextService;
        }

        public IEnumerable<CoachDto> GetAllCoachesFromClub(int clubId)
        {
            var Coaches = _dbContext.Coaches
                .Include(p => p.CoachOccupation)
                .Include(p => p.StaffAddress)
                .Where(p => p.ClubId == clubId)
                .ToList();

            if (!Coaches.Any())
                throw new NotFoundException("Coach not found");

            var result = _mapper.Map<List<CoachDto>>(Coaches);

            return result;
        }

        public CoachDto GetCoach(int Id)
        {
            var Coach = _dbContext.Coaches
                .Include(p => p.CoachOccupation)
                .Include(p => p.StaffAddress)
                .FirstOrDefault(p => p.Id == Id);

            if (Coach is null)
                throw new NotFoundException("Coach not found");

            var result = _mapper.Map<CoachDto>(Coach);

            return result;
        }

        public int CreateCoach(CreateCoachDto dto)
        {
            var occupation = _dbContext.CoachOccupations.FirstOrDefault(p => p.OccupationName == dto.CoachOccupationName);
            if (occupation is null)
                throw new NotFoundException("Occupation not found");

            var club = _dbContext.Clubs.FirstOrDefault(c => c.ShortName == dto.ClubName || c.FullName == dto.ClubName);
            if (club is null)
                throw new NotFoundException("Club not found");

            var coach = _mapper.Map<Coach>(dto);
            coach.CoachOccupation = occupation;
            coach.Club = club;

            var authorizationResult = _authorizationService.AuthorizeAsync(_userContextService.User, coach, new IsManagingThisClubRequirement()).Result;
            if (!authorizationResult.Succeeded)
                throw new ForbidException("You are not authorized");

            _dbContext.Coaches.Add(coach);
            _dbContext.SaveChanges();

            return coach.Id;
        }

        public void DeleteCoach(int Id)
        {
            var coach = _dbContext.Coaches
                .FirstOrDefault(p => p.Id == Id);

            if (coach == null)
                throw new NotFoundException("Coach not found");

            var authorizationResult = _authorizationService.AuthorizeAsync(_userContextService.User, coach, new IsManagingThisClubRequirement()).Result;
            if (!authorizationResult.Succeeded)
                throw new ForbidException("You are not authorized");

            _dbContext.Remove(coach);
            _dbContext.SaveChanges();
        }

        public void UpdateCoach (int Id, CreateCoachDto dto)
        {
            var coach = _dbContext.Coaches
                .Include(p => p.StaffAddress)
                .FirstOrDefault(p => p.Id == Id);
            if (coach == null)
                throw new NotFoundException("Coach not found");

            var occupation = _dbContext.CoachOccupations.FirstOrDefault(p => p.OccupationName == dto.CoachOccupationName);
            if (occupation is null)
                throw new NotFoundException("Occupation not found");

            var club = _dbContext.Clubs.FirstOrDefault(c => c.ShortName == dto.ClubName || c.FullName == dto.ClubName);
            if (club is null)
                throw new NotFoundException("Club not found");

            var authorizationResult = _authorizationService.AuthorizeAsync(_userContextService.User, coach, new IsManagingThisClubRequirement()).Result;
            if (!authorizationResult.Succeeded)
                throw new ForbidException("You are not authorized");

            coach.FirstName = dto.FirstName;
            coach.SecondName = dto.SecondName;
            coach.LastName = dto.LastName;
            coach.Nationality = dto.Nationality;
            coach.DateOfBirth = dto.DateOfBirth;
            coach.PlaceOfBirth = dto.PlaceOfBirth;
            coach.ContactEmail = dto.ContactEmail;
            coach.ContactNumber = dto.ContactNumber;
            coach.StaffAddress.City = dto.City;
            coach.StaffAddress.Street = dto.Street;
            coach.StaffAddress.PostalCode = dto.PostalCode;
            coach.CoachOccupation = occupation;

            if (_userContextService.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role).Value == "Admin")
                coach.Club = club;
            else
            {
                if (coach.Club != club)
                    throw new ForbidException("You are not authorized to change club for staffs");
            }

            _dbContext.SaveChanges();
        }
    }
}
