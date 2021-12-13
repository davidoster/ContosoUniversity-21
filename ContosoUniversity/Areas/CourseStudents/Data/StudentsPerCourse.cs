using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Areas.CourseStudents.Data
{
    public class StudentsPerCourse
    {
        public Course Course { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}