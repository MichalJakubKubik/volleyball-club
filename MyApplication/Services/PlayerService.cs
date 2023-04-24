using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MyApplication.Authorization;
using MyApplication.Entities;
using MyApplication.Exceptions;
using MyApplication.Migrations;
using MyApplication.Models;
using System.Security.Claims;

namespace MyApplication.Services
{
    public interface IPlayerService
    {
        PlayerDto GetPlayer(int Id);
        IEnumerable<PlayerDto> GetAllPlayersFromClub(int clubId);
        int CreatePlayer(CreatePlayerDto dto);
        void DeletePlayer(int id);
        void UpdatePlayer(int Id, CreatePlayerDto dto);
    }

    public class PlayerService : IPlayerService
    {
        private readonly IMapper _mapper;
        private readonly ClubDbContext _dbContext;
        private readonly ILogger<ClubService> _logger;
        private readonly IAuthorizationService _authorizationService;
        private readonly IUserContextService _userContextService;

        public PlayerService(ClubDbContext dbContext, IMapper mapper, ILogger<ClubService> logger, IAuthorizationService authorizationService, IUserContextService userContextService)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _logger = logger;
            _authorizationService = authorizationService;
            _userContextService = userContextService;
        }

        public IEnumerable<PlayerDto> GetAllPlayersFromClub(int clubId)
        {
            var players = _dbContext.Players
                .Include(p => p.PlayerPosition)
                .Include(p => p.StaffAddress)
                .Where(p => p.ClubId == clubId)
                .ToList();

            if (!players.Any())
                throw new NotFoundException("Club not found or any player in club");

            var result = _mapper.Map<List<PlayerDto>>(players);

            return result;
        }

        public PlayerDto GetPlayer(int Id)
        {
            var player = _dbContext.Players
                .Include(p => p.PlayerPosition)
                .Include(p => p.StaffAddress)
                .FirstOrDefault(p => p.Id == Id);

            if (player is null)
                throw new NotFoundException("Player not found");

            var result = _mapper.Map<PlayerDto>(player);

            return result;
        }

        public int CreatePlayer(CreatePlayerDto dto)
        {
            var position = _dbContext.PlayerPositions.FirstOrDefault(p => p.PositionName == dto.PositionName);
            if (position is null)
                throw new NotFoundException("Position not found");

            var club = _dbContext.Clubs.FirstOrDefault(c => c.ShortName == dto.ClubName || c.FullName == dto.ClubName);
            if (club is null)
                throw new NotFoundException("Club not found");

            var isThisNumberUsedAlready = _dbContext.Players.Where(p => p.ShirtNumber == dto.ShirtNumber && p.ClubId == club.Id);
            if (isThisNumberUsedAlready.Any())
                throw new NotFoundException("This shirt number is already used");

            var player = _mapper.Map<Player>(dto);

            player.PlayerPosition = position;

            player.Club = club;

            var authorizationResult = _authorizationService.AuthorizeAsync(_userContextService.User, player, new IsManagingThisClubRequirement()).Result;
            if (!authorizationResult.Succeeded)
                throw new ForbidException("You are not authorized");

            _dbContext.Players.Add(player);
            _dbContext.SaveChanges();

            return player.Id;
        }

        public void DeletePlayer(int Id)
        {
            var player = _dbContext.Players
                .FirstOrDefault(p => p.Id == Id);

            if (player == null)
                throw new NotFoundException("Player not found");

            var authorizationResult = _authorizationService.AuthorizeAsync(_userContextService.User, player, new IsManagingThisClubRequirement()).Result;
            if (!authorizationResult.Succeeded)
                throw new ForbidException("You are not authorized");

            _dbContext.Remove(player);
            _dbContext.SaveChanges();
        }

        public void UpdatePlayer(int Id, CreatePlayerDto dto)
        {
            var player = _dbContext.Players
                .Include(p => p.StaffAddress)
                .FirstOrDefault(p => p.Id == Id);
            if (player == null)
                throw new NotFoundException("Player not found");

            var position = _dbContext.PlayerPositions.FirstOrDefault(p => p.PositionName == dto.PositionName);
            if (position is null)
                throw new NotFoundException("Position not found");

            var club = _dbContext.Clubs.FirstOrDefault(c => c.ShortName == dto.ClubName || c.FullName == dto.ClubName);
            if (club is null)
                throw new NotFoundException("Club not found");

            var isThisNumberUsedAlready = _dbContext.Players.Where(p => p.ShirtNumber == dto.ShirtNumber && p.ClubId == club.Id);
            if (isThisNumberUsedAlready.Any())
                throw new NotFoundException("This shirt number is already used");

            var authorizationResult = _authorizationService.AuthorizeAsync(_userContextService.User, player, new IsManagingThisClubRequirement()).Result;
            if (!authorizationResult.Succeeded)
                throw new ForbidException("You are not authorized");

            player.FirstName = dto.FirstName;
            player.SecondName = dto.SecondName;
            player.LastName = dto.LastName;
            player.ShirtNumber = dto.ShirtNumber;
            player.Nationality = dto.Nationality;
            player.DateOfBirth = dto.DateOfBirth;
            player.PlaceOfBirth = dto.PlaceOfBirth;
            player.ContactEmail = dto.ContactEmail;
            player.ContactNumber = dto.ContactNumber;
            player.StaffAddress.City = dto.City;
            player.StaffAddress.Street = dto.Street;
            player.StaffAddress.PostalCode = dto.PostalCode;
            player.PlayerPosition = position;

            if (_userContextService.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role).Value == "Admin")
                player.Club = club;
            else
            {
                if (player.Club != club)
                    throw new ForbidException("You are not authorized to change club for staffs");
            }

            _dbContext.SaveChanges();
        }
    }
}
