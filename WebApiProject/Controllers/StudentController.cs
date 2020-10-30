using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiProject.DataAcces;
using WebApiProject.Interfaces;
using WebApiProject.Models;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {


        private IStudent studentRepository;
        ApplicationContext db;
        public StudentController(IStudent studentRepository, ApplicationContext db)
        {
            this.studentRepository = studentRepository;
            this.db = db;
        }


        [HttpGet("GetAllStudents")]
        public IEnumerable <Student> GetAllStudent()
        {



            var companies = db.Companies.Include("Users").ToList();
            var value = 0;





            IEnumerable<Student> students = studentRepository.Students;
            return students;
        }


        [HttpPost]
        public IActionResult SaveStudent(Student student)
        {
            studentRepository.SaveStudent(student);
            return Ok("Data au fost salvate cu succes");
        }

        [HttpPut]
        public IActionResult UpdateStudent([FromBody] Student student)
        {
            studentRepository.UpdateStudent(student);
            return Ok("Data au fost updtate cu succes");
        }
    }
}
