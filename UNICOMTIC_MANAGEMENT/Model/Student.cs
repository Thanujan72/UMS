using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNICOMTIC_MANAGEMENT.Model
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Adderss { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? CourseID { get; set; }
        public string CourseName { get; set; } // ← Add this
        //public Course Course { get; set; }
    }
}
