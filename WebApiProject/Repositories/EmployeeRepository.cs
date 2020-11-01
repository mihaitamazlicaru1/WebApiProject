using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProject.DataAcces;
using WebApiProject.Interfaces;
using WebApiProject.Models;

namespace WebApiProject.Repositories
{
    public class EmployeeRepository : IEmployee
    {

        private readonly ApplicationContext context;

        public EmployeeRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<Employee> Employees
        {
            get
            {
                return context.Employees.ToList();
            }
        }
    }
}
