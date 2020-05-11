using System.Web.Mvc;

namespace BestTraveling.Areas.College
{
    public class CollegeAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "College";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "College_default",
                "College/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}