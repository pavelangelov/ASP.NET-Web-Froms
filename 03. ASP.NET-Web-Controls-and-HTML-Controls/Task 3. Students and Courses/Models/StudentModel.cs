using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task_3.Students_and_Courses.Models
{
    public class StudentModel
    {
        public StudentModel()
        {
            this.Courses = new List<string>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FacultyNumber { get; set; }

        public string University { get; set; }

        public string Speciality { get; set; }

        public ICollection<string> Courses { get; set; }
    }
}