using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApiProject.DataAcces;
using WebApiProject.Interfaces;
using WebApiProject.Models;

namespace WebApiProject.Repositories
{
    public class StudentRepository : IStudent
    {

        private ApplicationContext context;

        public StudentRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<Student> Students
        {
            get
            {
                return context.Students;
            }
        }

        public void SaveStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {

            Student dbStudent = context.Students.FirstOrDefault(s => s.Id == student.Id);

                    //Review dbReview = context.Reviews.FirstOrDefault(r => r.Id == review.Id);
                    //dbReview.Name = review.Name;
                    //dbReview.Description = review.Description;
                    //context.SaveChanges();
               
        }
    }
}
