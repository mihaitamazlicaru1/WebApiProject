using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiProject.Models;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestApiController : ControllerBase
    {

        [HttpPost("PostValues")]
        public IActionResult CreateString(Company company)
        {
            return Ok("some string");
        }
    }
}
