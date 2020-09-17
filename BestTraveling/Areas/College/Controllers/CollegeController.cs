using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bt_Services.IServices;
using BT_Model;
using BT_Model.CollegeModel;
using BT.AdminService.IServices;


namespace BestTraveling.Areas.College.Controllers
{
    public class CollegeController : Controller
    {
        private readonly ICollegeService _collegeService = null;
        private readonly ICommonDataService _commonDataService = null;
        public CollegeController(ICollegeService _collegeService,ICommonDataService _commonDataService)
        {
            this._collegeService = _collegeService;
            this._commonDataService = _commonDataService;

        }

        public ActionResult List()
        {
            return View();
        }

        // GET: College/College
        public ActionResult Create()
        {
            ViewBag.Countries = _commonDataService.GetCountries().Select(x=>new SelectListItem {
                Value = x.CountryId.ToString(),Text = x.Name.ToString()
            });

            ViewBag.States = _commonDataService.GetStates().Select(x => new SelectListItem
            {
                Value = x.StateId.ToString(),Text = x.Name
            });

            ViewBag.Districts = _commonDataService.GetDistricts().Select(x=>new SelectListItem { Value = x.DistrictId.ToString(),Text = x.Name});
            ViewBag.Cities = _commonDataService.GetCities().Select(x=>new SelectListItem { Value = x.CityId.ToString(),Text = x.Name});

            return View(new CollegeModel());
        }

        [HttpPost]
        public ActionResult Create(CollegeModel model)
        {
            bool flag = false;
            return Json(flag,JsonRequestBehavior.AllowGet);
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}