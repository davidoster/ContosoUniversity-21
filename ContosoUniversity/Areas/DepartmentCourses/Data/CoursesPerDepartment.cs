using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContosoUniversity.Models;

namespace ContosoUniversity.Areas.DepartmentCourses.Data
{
    public class CoursesPerDepartment: IDisposable
    {
        public Department Department { get; set; }
        public ICollection<Course> Courses { get; set; }

        public void Dispose()
        {

        }
    }
}