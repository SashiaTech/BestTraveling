using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BT.AdminService.IServices;
using BT_Model.AdminModel;

namespace BestTraveling.Areas.Admin
{
    public class CityController : Controller
    {
        private readonly ICommonDataService _ICommonDataService = null;
        private readonly ICityService _ICityService = null;
        public CityController(ICommonDataService _ICommonDataService, ICityService _ICityService)
        {
            this._ICommonDataService = _ICommonDataService;
            this._ICityService = _ICityService;
        }
        // GET: Admin/City..........
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Read_Cities()
        {
            var model = _ICityService.GetCitis().ToList();
            return Json(model,JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddCity()
        {
            ViewBag.Countries = _ICommonDataService.GetCountries().Select(x=>new SelectListItem { Value = x.CountryId.ToString(),Text=x.Name});
            ViewBag.States = _ICommonDataService.GetStates().Select(x => new SelectListItem { Value = x.StateId.ToString(), Text = x.Name }).ToList();
            ViewBag.Districts = _ICommonDataService.GetDistricts().Select(x=>new SelectListItem { Value = x.DistrictId.ToString(),Text = x.Name}).ToList();
            return PartialView("~/Areas/Admin/Views/City/_AddCity.cshtml");
        }

        [HttpPost]
        public ActionResult AddCity(CityModel model)
        {
            bool flag = false;
            try
            {
                model.CityId = Guid.NewGuid();
                _ICityService.AddCity(model);
                flag = true;
            }
            catch(Exception ex)
            {
                flag = false;
            }

            return Json(flag,JsonRequestBehavior.AllowGet);
        }

        public ActionResult UpdateCity(Guid CityId)
        {
            ViewBag.Countries = _ICommonDataService.GetCountries().Select(x => new SelectListItem { Value = x.CountryId.ToString(), Text = x.Name });
            ViewBag.States = _ICommonDataService.GetStates().Select(x => new SelectListItem { Value = x.StateId.ToString(), Text = x.Name }).ToList();
            ViewBag.Districts = _ICommonDataService.GetDistricts().Select(x => new SelectListItem { Value = x.DistrictId.ToString(), Text = x.Name }).ToList();

            CityModel model =  _ICityService.GetCityById(CityId);
            return PartialView("~/Areas/Admin/Views/City/_UpdateCity.cshtml",model);
        }


        [HttpPost]
        public ActionResult UpdateCity(CityModel model)
        {
            bool flag = false;
            try
            {
                _ICityService.UpdateCity(model);
                flag = true;
            }
            catch(Exception ex)
            {
                flag = false;
            }

            return Json(flag,JsonRequestBehavior.AllowGet);
        }
        public ActionResult RemoveCity(Guid CityId)
        {
            bool flag = false;
            try
            {
                var model = _ICityService.GetCityById(CityId);
                _ICityService.RemoveCity(model);
                flag = true;
            }
            catch (Exception ex)
            {
                flag = false;
            }
            return Json(flag, JsonRequestBehavior.AllowGet);
        }
    }
}