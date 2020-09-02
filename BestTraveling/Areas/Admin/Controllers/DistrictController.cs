using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BT_Model.AdminModel;
using BT.AdminService.IServices;

namespace BestTraveling.Areas.Admin.Controllers
{
    public class DistrictController : Controller
    {
        private readonly IDistrictService _IDistrictService = null;
        private readonly ICountryService _ICountryService = null;
        private readonly IStateService _IStateService = null;
        private readonly ICommonDataService _ICommonDataService = null;
        public DistrictController(IDistrictService _IDistrictService, ICommonDataService _ICommonDataService, ICountryService _ICountryService, IStateService _IStateService)
        {
            this._IDistrictService= _IDistrictService;
            this._ICountryService = _ICountryService;
            this._IStateService = _IStateService;
            this._ICommonDataService= _ICommonDataService;
        }
        // GET: Admin/District
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Read_Districts()
        {
            var model = _IDistrictService.GetDistricts();
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddDistrict()
        {
            ViewBag.Countries = _ICommonDataService.GetCountries().Select(x=>new SelectListItem { Value = x.CountryId.ToString(),Text = x.Name});
            ViewBag.States = _ICommonDataService.GetStates().Select(x=>new SelectListItem { Value = x.StateId.ToString(),Text = x.Name});
            return PartialView("~/Areas/Admin/Views/District/_AddDistrict.cshtml");
        }

        [HttpPost]
        public ActionResult AddDistrict(DistrictModel model)
        {
            bool flag = false;
            try
            {
                model.DistrictId = Guid.NewGuid();
                _IDistrictService.AddDistrict(model);
                flag = true;
            }catch(Exception ex)
            {
                flag = false;
            }
            return Json(flag,JsonRequestBehavior.AllowGet);
        }

        public ActionResult UpdateDistrict(Guid DistrictId)
        {
            ViewBag.Countries = _ICommonDataService.GetCountries().Select(x => new SelectListItem { Value = x.CountryId.ToString(), Text = x.Name });
            ViewBag.States = _ICommonDataService.GetStates().Select(x => new SelectListItem { Value = x.StateId.ToString(), Text = x.Name });
            var model = _IDistrictService.GetDistrictById(DistrictId);
            return PartialView("~/Areas/Admin/Views/District/_UpdateDistrict.cshtml",model);
        }

        [HttpPost]
        public ActionResult UpdateDistrict(DistrictModel model)
        {
            bool flag = false;
            try
            {
                _IDistrictService.UpdateDistrict(model);
                flag = true;
            }
            catch (Exception ex)
            {
                flag = false;
            }
            return Json(flag,JsonRequestBehavior.AllowGet);
        }

        public ActionResult RemoveDistrict(Guid DistrictId)
        {
            bool flag = false;
            try
            {
                _IDistrictService.RemoveDistrict(DistrictId);
                flag = true;
            }catch(Exception ex)
            {
                flag = false;
            }
            return Json(flag,JsonRequestBehavior.AllowGet);
        }
    }
}