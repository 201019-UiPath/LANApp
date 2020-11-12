using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LLDB.Models;
using LLLib;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LLAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GameParticipantController : ControllerBase
    {
        private readonly IGameParticipantService gameParticipantService;

        public GameParticipantController(IGameParticipantService gameParticipantService)
        {
            this.gameParticipantService = gameParticipantService;
        }


        [HttpPost("add")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("allowedOrigins")]
        public IActionResult AddGameParticipant(GameParticipant participant)
        {
            try
            {
                gameParticipantService.AddGameParticipant(participant);
                return CreatedAtAction("AddGameParticipant", participant);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpPut("edit")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("allowedOrigins")]
        public IActionResult UpdateGameParticipant(GameParticipant participant)
        {
            try
            {
                gameParticipantService.UpdateGameParticipant(participant);
                return CreatedAtAction("UpdateGameParticipant", participant);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpDelete("delete")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("allowedOrigins")]
        public IActionResult DeleteGameParticipant(GameParticipant participant)
        {
            try
            {
                gameParticipantService.DeleteGameParticipant(participant);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpGet("get/{id}")]
        [Produces("application/json")]
        [EnableCors("allowedOrigins")]
        public IActionResult GetAllGameParticipantsByGameId(int id)
        {
            try
            {
                return Ok(gameParticipantService.GetAllGameParticipantsByGameId(id));
            } catch (Exception)
            {
                return StatusCode(500);
            }
        }

        }
    }
}
