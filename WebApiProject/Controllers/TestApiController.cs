using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiProject.Models;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestApiController : ControllerBase
    {
        private ILogger<TestApiController> logger;
        public TestApiController(ILogger<TestApiController> logger)
        {
            this.logger = logger;
        }

        [HttpGet("PostValues")]
        public IActionResult CreateString()
        {
            logger.LogWarning("SomeInfo from TestApiController");
            return Ok("some string");
        }
    }
}
