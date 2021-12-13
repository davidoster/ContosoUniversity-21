using ContosoUniversity.Areas.CourseStudents.Data;
using ContosoUniversity.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Areas.CourseStudents.Controllers
{
    public class CoursesPrivateController : Controller
    {
        // GET: CourseStudents/Home
        public ActionResult Index()
        {
            // LINQ 
            List<StudentsPerCourse> CourseStudents = new List<StudentsPerCourse>() { };
            SchoolContext db = new SchoolContext();

            foreach (var c in db.Courses.Where(e => e.Enrollments.Count > 0))
            {
                CourseStudents.Add(new StudentsPerCourse() { Course = c, Students = c.Enrollments.Select(s => s.Student).ToList() });
            }
            ViewBag.CourseStudents = CourseStudents;
            return View();
        }
    }
}