using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.DAL;
using ContosoUniversity.Areas.DepartmentCourses.Data;

namespace ContosoUniversity.Areas.DepartmentCourses.Controllers
{
    public class DepartmentPrivateController : Controller
    {
        // GET: DepartmentCourses/DepartmentPrivate
        public ActionResult Index()
        {
            // LINQ 
            SchoolContext db = new SchoolContext();
            List<CoursesPerDepartment> DepartmentCourses = new List<CoursesPerDepartment>();
            db.Departments.Where(d => d.Courses.Count > 0).ToList().ForEach(d => DepartmentCourses.Add(new CoursesPerDepartment() { Department = d, Courses = d.Courses }));
            ViewBag.DepartmentCourses = DepartmentCourses;
            return View();
        }
    }
}