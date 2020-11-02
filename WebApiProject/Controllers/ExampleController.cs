using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiProject.Interfaces;
using WebApiProject.Models;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly IEmployee repository;

        public ExampleController(IEmployee repository)
        {
            this.repository = repository;
        }
        [HttpGet("GetAllEmployees")]
        public IActionResult GetAllEmployees()
        {
            IEnumerable<Employee> employees = repository.Employees;
            if(employees.Count() != 0)
            {
                List<Employee> allEmp = new List<Employee>(employees);
                return Ok(allEmp);
            }
            else
            {
                return Ok("Empty list");
            }
        }


        [HttpPost("PostEmployee")]
        public IActionResult PostEmployee(Employee employee)
        {
            return Ok();
        }
    }
}
