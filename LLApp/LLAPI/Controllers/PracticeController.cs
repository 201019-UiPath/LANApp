using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LLAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PracticeController : ControllerBase
    {
        private readonly IPracticeService parentService;

        public PracticeController(IPracticeService parentService)
        {
            this.parentService = parentService;
        }

        [HttpPost("add")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("allowedOrigins")]
        public IActionResult AddParent(Parent parent)
        {
            try
            {
                parentService.AddParent(parent);
                return CreatedAtAction("AddParent", parent);
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
        public IActionResult UpdateParent(Parent parent)
        {
            try
            {
                parentService.UpdateParent(parent);
                return CreatedAtAction("UpdateParent", parent);
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
        public IActionResult DeleteParent(Parent parent)
        {
            try
            {
                parentService.DeleteParent(parent);
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
        public IActionResult GetAllParents()
        {
            try
            {
                return Ok(parentService.GetAllParents());
            } catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("get/{id}")]
        [Produces("application/json")]
        [EnableCors("allowedOrigins")]
        public IActionResult GetAllParentsByChildId(int id)
        {
            try
            {
                return Ok(parentService.GetAllParentsByChildId(id));
            } catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
