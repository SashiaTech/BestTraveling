using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;
using BT.AdminService.IServices;
using BT_Model.AdminModel;

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

        public ActionResult AddOperator()
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

            ViewBag.Designations = _ICommonDataService.GetDesignations().Select(x => new SelectListItem
            {
                Value = x.DesignationId.ToString(),
                Text = x.Name
            });


            return PartialView("~/Areas/Admin/Views/Office/_AddOperator.cshtml");
        }

        [HttpPost]
        public ActionResult AddOperator(OperatorModel model)
        {
            bool flag = false;
            try
            {
                model.OperatorId = Guid.NewGuid();
                model.CreatedDateTime = DateTime.UtcNow;



                AddressModel addressModel = new AddressModel();
                addressModel.AddressId = Guid.NewGuid();
                addressModel.Address1 = model.Address;
                addressModel.CountryId = model.CountryId;
                addressModel.StateId = model.StateId;
                addressModel.CityId = model.CityId;
                addressModel.DistrictId = model.DistrictId;

                model.AddressId = addressModel.AddressId;
                StringBuilder xml = new StringBuilder();
                StringBuilder xml2 = new StringBuilder();
                XmlSerializer serializer = new XmlSerializer(typeof(AddressModel));
                XmlWriterSettings settings = new XmlWriterSettings()
                {
                    Encoding = new UnicodeEncoding(false, false)
                };

                using (XmlWriter xw = XmlWriter.Create(xml, settings))
                {
                    serializer.Serialize(xw, addressModel);
                }

                string OperatorAddressXml = xml.ToString();

                XmlSerializer serializer2 = new XmlSerializer(typeof(OperatorModel));
                XmlWriterSettings settings2 = new XmlWriterSettings()
                {
                    Encoding = new UnicodeEncoding(false, false)
                };
                using (XmlWriter xw2 = XmlWriter.Create(xml2, settings2))
                {
                    serializer2.Serialize(xw2, model);
                }

                string OperatorDetailXml = xml2.ToString();
                _IOperatorService.AddOperator(OperatorAddressXml,OperatorDetailXml);

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