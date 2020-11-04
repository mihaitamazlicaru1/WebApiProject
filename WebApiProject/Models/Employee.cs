using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProject.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string FirstName {get;set;}

        public string LastName { get; set; }

        public string EmailID { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public byte[] Image { get; set; }

    }
}
