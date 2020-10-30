using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProject.Models;

namespace WebApiProject.Interfaces
{
    public interface IStudent
    {
        IEnumerable<Student> Students {get;}
        void SaveStudent(Student student);
        public void UpdateStudent(Student student);


    }
}
