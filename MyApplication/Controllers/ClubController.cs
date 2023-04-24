using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApplication.Entities;
using MyApplication.Models;
using MyApplication.Services;
using static System.Reflection.Metadata.BlobBuilder;

namespace MyApplication.Controllers
{
    [Route("Club")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        private readonly IClubService _clubService;
        public ClubController(IClubService clubService)
        {
            _clubService = clubService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ClubDto>> GetAllClubs([FromQuery] ClubQuery query)
        {
            var clubs = _clubService.GetAllClubs(query);

            return Ok(clubs);
        }

        [HttpGet("{id}")]
        public ActionResult<ClubDto> GetClub([FromRoute] int id)
        {
            var club = _clubService.GetClub(id);

            return Ok(club);
        }

        [HttpGet("league/{leagueNumber}")]
        public ActionResult<IEnumerable<ClubDto>> GetClubsByLeague([FromRoute] int leagueNumber)
        {
            var clubs = _clubService.GetClubsByLeague(leagueNumber);

            return Ok(clubs);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public ActionResult DeleteClub([FromRoute] int id)
        {
            _clubService.DeleteClub(id);

            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult CreateClub([FromBody] CreateClubDto dto)
        {
            var id = _clubService.CreateClub(dto);

            return Created($"/Club/{id}", null);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public ActionResult UpdateClub([FromRoute] int id, [FromBody] CreateClubDto dto)
        {
            _clubService.UpdateClub(id, dto);

            return Ok();
        }
    }
}
