using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BT.AdminService.IServices;

namespace BestTraveling.Areas.Admin.Controllers
{
    public class OperatorsController : Controller
    {
        private readonly ICommonDataService _ICommonDataService = null;
        private readonly IOperatorService _IOperatorService = null;
        public OperatorsController(ICommonDataService _ICommonDataService, IOperatorService _IOperatorService)
        {
            this._ICommonDataService = _ICommonDataService;
            this._IOperatorService = _IOperatorService;
        }

        // GET: Admin/Operators
        public ActionResult List()
        {
            return View();
        }

        public ActionResult AddOperations()
        {
            ViewBag.Countries = _ICommonDataService.GetCountries().Select(x => new SelectListItem
            {
                Value = x.CountryId.ToString(),
                Text = x.Name
            });

            ViewBag.States = _ICommonDataService.GetStates().Select(x => new SelectListItem
            {
                Value = x.StateId.ToString(),
                Text = x.Name
            });

            ViewBag.Districts = _ICommonDataService.GetDistricts().Select(x => new SelectListItem
            {
                Value = x.DistrictId.ToString(),
                Text = x.Name
            });

            ViewBag.Cities = _ICommonDataService.GetCities().Select(x => new SelectListItem
            {
                Value = x.CityId.ToString(),
                Text = x.Name
            });

            return PartialView("~/Areas/Admin/Views/Office/_AddOperator.cshtml");
        }
    }
}