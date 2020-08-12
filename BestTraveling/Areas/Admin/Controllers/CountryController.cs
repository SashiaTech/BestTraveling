using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BT_Model.AdminModel;

namespace BestTraveling.Areas.Admin.Controllers
{
    public class CountryController : Controller
    {
        // GET: Admin/Country
        public ActionResult List()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public void Add(CountryModel model)
        {
            try
            {

            }
            catch(Exception ex)
            {

            }
        }
    }
}