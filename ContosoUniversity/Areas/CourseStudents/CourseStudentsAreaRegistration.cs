using System.Web.Mvc;

namespace ContosoUniversity.Areas.CourseStudents
{
    public class CourseStudentsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CourseStudents";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CourseStudents_default",
                "CourseStudents/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}