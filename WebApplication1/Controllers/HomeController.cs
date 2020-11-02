using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using WebApplication1.GlobalVariables;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {


        [HttpGet]
        public IActionResult Part2()
        {
            GLobalVariable gLobalVariable = new GLobalVariable();
            var value = gLobalVariable.GetAllEmployeesFromWebApi();
            return View();
        }

        [HttpPost]
        public IActionResult Part2(EmployeesViweModels employeesViweModels)
        {
            return View();
        }
    }
}
