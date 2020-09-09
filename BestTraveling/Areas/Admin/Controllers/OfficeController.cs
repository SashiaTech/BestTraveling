using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BT_Model.AdminModel;
using BT.AdminService.IServices;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace BestTraveling.Areas.Admin.Controllers
{
    public class OfficeController : Controller
    {
        private readonly ICommonDataService _ICommonDateService = null;
        private readonly IOfficeService _IOfficeService = null;
        public OfficeController(ICommonDataService _ICommonDateService, IOfficeService _IOfficeService)
        {
            this._ICommonDateService = _ICommonDateService;
            this._IOfficeService = _IOfficeService;
        }
        public ActionResult list()
        {
            return View();
        }

        public ActionResult Read_Offices()
        {
            var model = _IOfficeService.GetOffices();
            return Json(model,JsonRequestBehavior.AllowGet);
        }

        // GET: Admin/Office
        public ActionResult AddOffice()
        {
            OfficeModel model = new OfficeModel();
            ViewBag.Countries = _ICommonDateService.GetCountries().Select(x => new SelectListItem
            {
                Value = x.CountryId.ToString(),
                Text = x.Name
            });

            ViewBag.States = _ICommonDateService.GetStates().Select(x => new SelectListItem
            {
                Value = x.StateId.ToString(),
                Text = x.Name
            });

            ViewBag.Districts = _ICommonDateService.GetDistricts().Select(x => new SelectListItem
            {
                Value = x.DistrictId.ToString(),
                Text = x.Name
            });

            ViewBag.Cities = _ICommonDateService.GetCities().Select(x => new SelectListItem
            {
                Value = x.CityId.ToString(),
                Text = x.Name
            });
            model.AddressId = Guid.NewGuid();
            //model.OfficeId = Guid.NewGuid();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddOffice(OfficeModel model)
        {
            bool flag = false;
            try
            {
                AddressModel addressDetail = new AddressModel();
                addressDetail.AddressId = (Guid)model.AddressId;
                addressDetail.Address1 = model.Address1;
                addressDetail.Address2 = model.Address2;
                addressDetail.Address3 = model.Address3;
                addressDetail.CountryId = model.CountryId;
                addressDetail.DistrictId = model.DistrictId;
                addressDetail.StateId = model.StateId;
                addressDetail.CityId = model.CityId;
                model.OfficeId = Guid.NewGuid();


                model.CreatedDateTime = DateTime.UtcNow;


                StringBuilder xml = new StringBuilder();
                StringBuilder xml2 = new StringBuilder();

                XmlSerializer serializer = new XmlSerializer(typeof(AddressModel));
                XmlWriterSettings settings = new XmlWriterSettings()
                {
                    Encoding = new UnicodeEncoding(false, false)
                };

                using (XmlWriter xw = XmlWriter.Create(xml, settings))
                {
                    serializer.Serialize(xw, addressDetail);
                }
                string OfficeAddressXml = xml.ToString();

                XmlSerializer serializer2 = new XmlSerializer(typeof(OfficeModel));
                XmlWriterSettings settings2 = new XmlWriterSettings()
                {
                    Encoding = new UnicodeEncoding(false, false)
                };
                using (XmlWriter xw2 = XmlWriter.Create(xml2, settings2))
                {
                    serializer2.Serialize(xw2, model);
                }

                string OfficeDetailXml = xml2.ToString();
                _IOfficeService.AddOfficeByXml(OfficeAddressXml, OfficeDetailXml);


                flag = true;
            }
            catch (Exception ex)
            {
                flag = false;
            }

            return Json(flag, JsonRequestBehavior.AllowGet);
        }

        public ActionResult UpdateOffice(Guid OfficeId)
        {
            var model = _IOfficeService.GetOfficeById(OfficeId);
            ViewBag.Countries = _ICommonDateService.GetCountries().Select(x => new SelectListItem
            {
                Value = x.CountryId.ToString(),
                Text = x.Name
            });

            ViewBag.States = _ICommonDateService.GetStates().Select(x => new SelectListItem
            {
                Value = x.StateId.ToString(),
                Text = x.Name
            });

            ViewBag.Districts = _ICommonDateService.GetDistricts().Select(x => new SelectListItem
            {
                Value = x.DistrictId.ToString(),
                Text = x.Name
            });

            ViewBag.Cities = _ICommonDateService.GetCities().Select(x => new SelectListItem
            {
                Value = x.CityId.ToString(),
                Text = x.Name
            });
            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateOffice(OfficeModel model)
        {
            bool flag = false;
            try
            {
                AddressModel addressModel = new AddressModel();
                addressModel.AddressId = (Guid)model.AddressId;
                addressModel.Address1 = model.Address1;
                addressModel.Address2 = model.Address2;
                addressModel.Address3 = model.Address3;
                addressModel.CountryId = model.CountryId;
                addressModel.StateId = model.StateId;
                addressModel.CityId = model.CityId;

                StringBuilder xml = new StringBuilder();
                StringBuilder xml2 = new StringBuilder();
                XmlSerializer serializer = new XmlSerializer(typeof(AddressModel));
                XmlWriterSettings settings = new XmlWriterSettings()
                {
                    Encoding = new UnicodeEncoding(false,false)
                };
                using (XmlWriter xw=XmlWriter.Create(xml,settings))
                {
                    serializer.Serialize(xw,addressModel);
                }
                string OfficeAddressXml = xml.ToString();



                XmlSerializer serializer2 = new XmlSerializer(typeof(OfficeModel));
                XmlWriterSettings settings2 = new XmlWriterSettings()
                {
                    Encoding = new UnicodeEncoding(false,false)
                };
                using (XmlWriter xw2=XmlWriter.Create(xml2,settings2))
                {
                    serializer2.Serialize(xw2,model);
                }
                string OfficeDetailModel = xml2.ToString();

                 _IOfficeService.UpdateOfficeByXml(OfficeAddressXml, OfficeDetailModel);

                flag = true;

            } catch(Exception ex)
            {
                flag = false;
            }
            return Json(flag,JsonRequestBehavior.AllowGet);
        }

    }
}