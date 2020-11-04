using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
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
        public async Task<IActionResult> Part2(EmployeesViweModels employeesViweModels, IFormFile Image)
        {
            string message = string.Empty;
            using (var client = new HttpClient())
            {
                //foreach(var item in Image)
                //{
                if (Image.Length > 0)
                {
                    using (var stream = new MemoryStream())
                    {
                        await Image.CopyToAsync(stream);
                        employeesViweModels.Image = stream.ToArray();
                    }
                }
                //}
                client.BaseAddress = new Uri("https://localhost:44351/api/Example/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await client.PostAsJsonAsync<EmployeesViweModels>("PostEmployee", employeesViweModels);
                if (res.IsSuccessStatusCode)
                {
                    message = "Save Date succesful";
                }
                else
                {
                    message = "Save Filed";
                }
            }
            return View();
        }

        private void Methode()
        {

        }
    }
}
