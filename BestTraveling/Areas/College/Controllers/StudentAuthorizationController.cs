using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BestTraveling.Areas.College.Controllers
{
    public class StudentAuthorizationController : Controller
    {
        // GET: College/StudentAuthorization
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}