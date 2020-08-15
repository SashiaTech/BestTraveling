using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BestTraveling.Areas.Admin.Controllers
{
    public class DistrictController : Controller
    {
        // GET: Admin/District
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