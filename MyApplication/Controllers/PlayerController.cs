using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyApplication.Entities;
using MyApplication.Models;
using MyApplication.Services;
using System.Numerics;

namespace MyApplication.Controllers
{
    [Route("player")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet("club/{clubId}")]
        public ActionResult<IEnumerable<PlayerDto>> GetAllPlayersFromCLub([FromRoute] int clubId)
        {
            var players = _playerService.GetAllPlayersFromClub(clubId);

            return Ok(players);
        }

        [HttpGet("{Id}")]
        public ActionResult<PlayerDto> GetPlayer([FromRoute] int Id)
        {
            var player = _playerService.GetPlayer(Id);

            return Ok(player);
        }

        [HttpPost]
        public ActionResult<PlayerDto> CreatePlayer([FromBody] CreatePlayerDto dto)
        {
            var id = _playerService.CreatePlayer(dto);

            return Created($"/player/{id}", null);
        }

        [HttpDelete("{Id}")]
        public ActionResult<PlayerDto> DeletePlayer([FromRoute] int Id)
        {
            _playerService.DeletePlayer(Id);

            return NoContent();
        }

        [HttpPut("{Id}")]
        public ActionResult<PlayerDto> UpdatePlayer([FromBody] CreatePlayerDto dto, [FromRoute] int Id)
        {
            _playerService.UpdatePlayer(Id, dto);

            return Ok();
        }
    }
}
