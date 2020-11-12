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
    public class TeamController : ControllerBase
    {
        private readonly ITeamService teamService;

        public TeamController(ITeamService teamService)
        {
            this.teamService = teamService;
        }

        [HttpPost("add")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("allowedOrigins")]
        public IActionResult AddTeam(Team team)
        {
            try
            {
                teamService.AddTeam(team);
                return CreatedAtAction("AddTeam", team);
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
        public IActionResult UpdateTeam(Team team)
        {
            try
            {
                teamService.UpdateTeam(team);
                return CreatedAtAction("UpdateTeam", team);
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
        public IActionResult DeleteTeam(Team team)
        {
            try
            {
                teamService.DeleteTeam(team);
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
        public IActionResult GetAllTeams()
        {
            try
            {
                return Ok(teamService.GetAllTeams());
            } catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
