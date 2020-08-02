using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BT_Model;

namespace BestTraveling.Areas.Admin
{
    public class FairsController : Controller
    {
        // GET: Admin/Fairs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddFair()
        {
            return View(new FairsModel());
        }
    }
}