using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BestTraveling.Areas.Admin.Controllers
{
    public class StateController : Controller
    {
        // GET: Admin/State
        public ActionResult List()
        {
            return View();
        }
    }
}