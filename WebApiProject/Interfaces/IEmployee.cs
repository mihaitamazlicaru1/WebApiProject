using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProject.Models;

namespace WebApiProject.Interfaces
{
    public interface IEmployee
    {
        IEnumerable<Employee> Employees { get; }
    }
}
