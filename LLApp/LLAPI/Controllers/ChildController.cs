﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LLDB.Models;
using Microsoft.AspNetCore.Cors;

namespace LLAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        // private readonly IChildService childService;

        // public ChildController(IChildService childService)
        // {
        //     this.childService = childService;
        // }

        [HttpPost("add")]
        [Consumes("application/json")]
        [Produces("application/json")]
        [EnableCors("allowedOrigins")]
        public IActionResult AddChild(Child child)
        {
            try
            {
                //childService.AddChild(child);
                return CreatedAtAction("AddChild", child);
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
        public IActionResult UpdateChild(Child child)
        {
            try
            {
                //childService.UpdateChild(child);
                return CreatedAtAction("UpdateChild", child);
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
        public IActionResult DeleteChild(Child child)
        {
            try
            {
                //childService.DeleteChild(child);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }






    }
}