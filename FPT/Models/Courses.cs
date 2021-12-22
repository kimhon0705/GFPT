using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FPT.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public DateTime CourseDate { get; set; }
        public string Author { get; set; }
    }
}