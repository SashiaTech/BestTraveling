using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BestTraveling.Areas.Admin.Controllers
{
    public class CollegePermissionController : Controller
    {
        // GET: Admin/CollegePermission
        public ActionResult List()
        {
            return View();
        }

        public ActionResult AddPermission()
        {
           return View();
        }

    }
}