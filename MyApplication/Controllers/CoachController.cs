using Microsoft.AspNetCore.Mvc;
using MyApplication.Entities;
using MyApplication.Models;
using MyApplication.Services;
using System.Numerics;

namespace MyApplication.Controllers
{
    [Route("coach")]
    [ApiController]
    public class CoachController : ControllerBase
    {
        private readonly ICoachService _coachService;
        public CoachController(ICoachService coachService)
        {
            _coachService = coachService;
        }

        [HttpGet("club/{clubId}")]
        public ActionResult<IEnumerable<CoachDto>> GetAllCoachesFromCLub([FromRoute] int clubId)
        {
            var coaches = _coachService.GetAllCoachesFromClub(clubId);

            return Ok(coaches);
        }

        [HttpGet("{Id}")]
        public ActionResult<CoachDto> GetCoach([FromRoute] int Id)
        {
            var coach = _coachService.GetCoach(Id);

            return Ok(coach);
        }

        [HttpPost]
        public ActionResult<CoachDto> CreateCoach([FromBody] CreateCoachDto dto)
        {
            var id = _coachService.CreateCoach(dto);

            return Created($"/coach/{id}", null);
        }

        [HttpDelete("{Id}")]
        public ActionResult<CoachDto> DeleteCoach([FromRoute] int Id)
        {
            _coachService.DeleteCoach(Id);

            return NoContent();
        }

        [HttpPut("{Id}")]
        public ActionResult<CoachDto> UpdateCoach([FromBody] CreateCoachDto dto, [FromRoute] int Id)
        {
            _coachService.UpdateCoach(Id, dto);

            return Ok();
        }
    }
}
