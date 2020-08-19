using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BT_Model.AdminModel;
using BT.AdminService.IServices;
namespace BestTraveling.Areas.Admin.Controllers
{
    public class CountryController : Controller
    {

        private readonly ICountryService _countryService = null;
        public CountryController(ICountryService _countryService)
        {
            this._countryService = _countryService;
        }

        // GET: Admin/Country
        public ActionResult List()
        {
            return View();
        }

        public JsonResult Country_Read()
        {
           var Countries =  _countryService.GetCountries();
            return Json(Countries,JsonRequestBehavior.AllowGet);
        }


        public ActionResult AddCountry()
        {
            return PartialView("~/Areas/Admin/Views/Country/_AddCountry.cshtml", new CountryModel());
        }

        [HttpPost]
        public JsonResult AddCountry(CountryModel model)
        {
            bool flag = false;
            try
            {

                model.CountryId = Guid.NewGuid();
                _countryService.AddCountry(model);
                flag = true;
            }
            catch (Exception ex)
            {
                flag = false;
            }
            return Json(flag);
        }
    }
}