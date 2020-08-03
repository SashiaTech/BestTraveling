using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bt_Services.IServices;
using BT_Model;

namespace BestTraveling.Areas.College.Controllers
{
    public class CollegeController : Controller
    {
        ICollegeService _collegeService = null;
        

        public CollegeController(ICollegeService _collegeService)
        {
            this._collegeService = _collegeService;
        }

        public ActionResult List()
        {
            return View();
        }

        // GET: College/College
        public ActionResult Create()
        {
            return View(new CollegeModel());
        }
        
        public ActionResult index()
        {
            return View();
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}