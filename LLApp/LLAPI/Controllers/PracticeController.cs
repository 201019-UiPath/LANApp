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
    public class PracticeController : ControllerBase
    {
        private readonly IPracticeService practiceService;

        public PracticeController(IPracticeService practiceService)
        {
            this.practiceService = practiceService;
        }

        [HttpPost("add")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("allowedOrigins")]
        public IActionResult AddPractice(Practice practice)
        {
            try
            {
                practiceService.AddPractice(practice);
                return CreatedAtAction("AddPractice", practice);
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
        public IActionResult UpdatePractice(Practice practice)
        {
            try
            {
                practiceService.UpdatePractice(practice);
                return CreatedAtAction("UpdatePractice", practice);
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
        public IActionResult DeletePractice(Practice practice)
        {
            try
            {
                practiceService.DeletePractice(practice);
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
        public IActionResult GetAllPracticesByTeamId(int id)
        {
            try
            {
                return Ok(practiceService.GetAllPracticesByTeamId(id));
            } catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
