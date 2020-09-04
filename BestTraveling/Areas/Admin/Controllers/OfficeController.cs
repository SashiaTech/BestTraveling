using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BT_Model.AdminModel;
using BT.AdminService.IServices;

namespace BestTraveling.Areas.Admin.Controllers
{
    public class OfficeController : Controller
    {
        private readonly ICommonDataService _ICommonDateService = null;
        public OfficeController(ICommonDataService _ICommonDateService)
        {
            this._ICommonDateService = _ICommonDateService;
        }
        public ActionResult list()
        {
            return View();
        }

        // GET: Admin/Office
        public ActionResult AddOffice()
        {
            ViewBag.Countries = _ICommonDateService.GetCountries().Select(x=>new SelectListItem {
                Value = x.CountryId.ToString(),
                Text = x.Name
            });

            ViewBag.States = _ICommonDateService.GetStates().Select(x=>new SelectListItem {
                Value = x.StateId.ToString(),
                Text = x.Name
            });

            ViewBag.Districts = _ICommonDateService.GetDistricts().Select(x => new SelectListItem {
                Value = x.DistrictId.ToString(),
                Text = x.Name
            });

            ViewBag.Cities = _ICommonDateService.GetCities().Select(x => new SelectListItem {
                Value = x.CityId.ToString(),
                Text = x.Name
            });

            return View();
        }
        
        //[HttpPost]
        //public ActionResult AddOffice(OfficeModel model)
        //{

        //}


    }
}