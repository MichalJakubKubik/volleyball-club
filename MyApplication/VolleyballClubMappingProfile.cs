using AutoMapper;
using MyApplication.Entities;
using MyApplication.Models;

namespace MyApplication
{
    public class VolleyballClubMappingProfile : Profile
    {
        public VolleyballClubMappingProfile()
        {
            CreateMap<Club, ClubDto>()
                .ForMember(m => m.City, c => c.MapFrom(s => s.ClubAddress.City))
                .ForMember(m => m.Street, c => c.MapFrom(s => s.ClubAddress.Street))
                .ForMember(m => m.PostalCode, c => c.MapFrom(s => s.ClubAddress.PostalCode))
                .ForMember(m => m.LeagueName, c => c.MapFrom(s => s.LeagueLevel.LeagueName));

            CreateMap<Player, PlayerDto>()
                .ForMember(m => m.PlayerPosition, c => c.MapFrom(s => s.PlayerPosition.PositionName));

            CreateMap<Coach, CoachDto>()
                .ForMember(m => m.CoachOccupation, c => c.MapFrom(s => s.CoachOccupation.OccupationName));

            CreateMap<CreateClubDto, Club>()
                .ForMember(m => m.ClubAddress, c => c.MapFrom(dto => new ClubAddress
                {
                    City = dto.City,
                    Street = dto.Street,
                    PostalCode = dto.PostalCode
                }));
            CreateMap<CreatePlayerDto, Player>()
                .ForMember(m => m.StaffAddress, c => c.MapFrom(dto => new StaffAddress
                {
                    City = dto.City,
                    Street = dto.Street,
                    PostalCode = dto.PostalCode
                }));
            CreateMap<CreateCoachDto, Coach>()
                .ForMember(m => m.StaffAddress, c => c.MapFrom(dto => new StaffAddress
                {
                    City = dto.City,
                    Street = dto.Street,
                    PostalCode = dto.PostalCode
                }));
        }
    }
}
