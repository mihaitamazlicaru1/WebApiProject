using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.GlobalVariables
{
    public class GLobalVariable
    {
        private HttpClient client;

        public GLobalVariable()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44351/api/Example/")
            };
        }

        public List<EmployeesViweModels> GetAllEmployeesFromWebApi()
        {
            List<EmployeesViweModels> empViewModel = new List<EmployeesViweModels>();
            try
            {
                HttpResponseMessage responseTask = client.GetAsync("GetAllEmployees").Result;
                if (responseTask.IsSuccessStatusCode)
                {
                    Task<List<EmployeesViweModels>> readTask = responseTask.Content.ReadAsAsync<List<EmployeesViweModels>>();
                    readTask.Wait();
                    empViewModel.AddRange(readTask.Result);
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message.ToString();
            }
            return empViewModel;
        }
    }
}
