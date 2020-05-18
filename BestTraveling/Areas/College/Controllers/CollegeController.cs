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

        // GET: College/College
        public ActionResult Create()
        {
            CollegeModel model = new CollegeModel();
            model.Name = _collegeService.Create();
            return View(model);
        }
        
        public ActionResult index()
        {
            return View();
        }
    }
}