using System.Web.Mvc;

namespace ContosoUniversity.Areas.DepartmentCourses
{
    public class DepartmentCoursesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "DepartmentCourses";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "DepartmentCourses_default",
                "DepartmentCourses/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}