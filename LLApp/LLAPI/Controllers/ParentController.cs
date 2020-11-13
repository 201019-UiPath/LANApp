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
    public class ParentController : ControllerBase
    {
         private readonly IParentService parentService;

        public ParentController(IParentService parentService)
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

        [HttpGet("get/{ParentId}")]
        [Produces("application/json")]
        [EnableCors("allowedOrigins")]
        public IActionResult GetParentById(int ParentId)
        {
            try
            {
                return Ok(parentService.GetParentById(ParentId));
            } catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
