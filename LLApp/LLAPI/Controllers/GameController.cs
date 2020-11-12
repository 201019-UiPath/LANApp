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
    public class GameController : ControllerBase
    {
        private readonly IGameService gameService;

        public GameController(IGameService gameService)
        {
            this.gameService = gameService;
        }


        [HttpPost("add")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("allowedOrigins")]
        public IActionResult AddGame(Game game)
        {
            try
            {
                gameService.AddGame(game);
                return CreatedAtAction("AddGame", game);
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
        public IActionResult UpdateGame(Game game)
        {
            try
            {
                gameService.UpdateGame(game);
                return CreatedAtAction("UpdateGame", game);
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
        public IActionResult DeleteGame(Game game)
        {
            try
            {
                gameService.DeleteGame(game);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [HttpGet("get")]
        [Produces("application/json")]
        [EnableCors("allowedOrigins")]
        public IActionResult GetAllGames()
        {
            try
            {
                return Ok(gameService.GetAllGames());
            } catch (Exception)
            {
                return StatusCode(500);
            }
        }


        [HttpGet("get/{id}")]
        [Produces("application/json")]
        [EnableCors("allowedOrigins")]
        public IActionResult GetAllGamesByTeamId(int id)
        {
            try
            {
                return Ok(gameService.GetAllGamesByTeamId(id));
            } catch (Exception)
            {
                return StatusCode(500);
            }
        }



    }
}
