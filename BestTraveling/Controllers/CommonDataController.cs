using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BT.AdminService.IServices;
using BT_Model.AdminModel;


namespace BestTraveling.Controllers
{
    public class CommonDataController : Controller
    {
        private readonly ICountryService _ICountryService = null;
        private readonly IStateService _IStateService = null;


        public CommonDataController(ICountryService _ICountryService, IStateService _IStateService)
        {
            this._ICountryService = _ICountryService;
            this._IStateService = _IStateService;
        }

        // GET: CommonData
        public ActionResult GetCountries()
        {
           var countries = _ICountryService.GetCountries().Select(x=> new SelectListItem{
               Text = x.Name,
               Value = x.CountryId.ToString()
            }).OrderBy(x=>x.Text);
            return Json(countries,JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetStates()
        {
            var states = _IStateService.GetStates().Select(x=>new SelectListItem {
                Text = x.Name,
                Value = x.StateId.ToString()
            }).OrderBy(x=>x.Text);
            return Json(states,JsonRequestBehavior.AllowGet);
        }


    }
}