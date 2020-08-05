using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BestTraveling.Areas.Admin.Controllers
{
    public class CountryController : Controller
    {
        // GET: Admin/Country
        public ActionResult List()
        {
            return View();
        }
    }
}