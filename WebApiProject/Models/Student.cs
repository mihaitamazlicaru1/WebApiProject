using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProject.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string f_name { get; set; }

        public string m_name { get; set; }

        public string l_name { get; set; }

        public string address { get; set; }

        public DateTime birthDay { get; set; }

        public string score { get; set; }

        public string dep_id { get; set; }
    }
}
