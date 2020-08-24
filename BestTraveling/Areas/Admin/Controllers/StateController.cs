using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BT.AdminService.IServices;
using BT_Model.AdminModel;


namespace BestTraveling.Areas.Admin.Controllers
{
    public class StateController : Controller
    {
        private readonly IStateService _IStateService = null;
        private readonly ICountryService _ICountryService = null;
        // GET: Admin/State
        public StateController(IStateService _IStateService, ICountryService _ICountryService)
        {
            this._IStateService = _IStateService;
            this._ICountryService = _ICountryService;
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult State_Read()
        {
            var model = _IStateService.GetStates();
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddState()
        {
            var model = _ICountryService.GetCountries().Select(x => new SelectListItem {
                Text = x.Name,
                Value = x.CountryId.ToString()
            });

            ViewBag.Countries = model;
            return PartialView("~/Areas/Admin/Views/State/_AddState.cshtml");
        }

        [HttpPost]
        public ActionResult AddState(StateModel model)
        {
            bool flag = false;
            try
            {
                if (ModelState.IsValid)
                {

                    model.StateId = Guid.NewGuid();
                    _IStateService.AddState(model);
                    flag = true;
                }
            } catch (Exception e)
            {
                flag = false;
            }
            return Json(flag, JsonRequestBehavior.AllowGet);
        }


        public ActionResult UpdateState(Guid StateId)
        {
            var model = _IStateService.GetStateById(StateId);
            ViewBag.Countries = _ICountryService.GetCountries().Select(x => new SelectListItem {
                Text = x.Name,
                Value = x.CountryId.ToString()
            }).OrderBy(x => x.Text);
            return PartialView("~/Areas/Admin/Views/State/_UpdateState.cshtml", model);
        }


         [HttpPost]
        public ActionResult UpdateState(StateModel model)
        {
            bool flag = false;
            try
            {
                if (ModelState.IsValid)
                {
                    _IStateService.UpdateState(model);
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                flag = false;
            }
            return Json(flag,JsonRequestBehavior.AllowGet);
        }


        public ActionResult DeleteState(Guid StateId)
        {
            bool flag = false;
            try
            {
                StateModel model = _IStateService.GetStateById(StateId);
                model.IsDeleted = true;
                _IStateService.RemoveState(model);

                flag = true;
            }
            catch (Exception ex)
            {
                flag = false;
            }
            return Json(flag,JsonRequestBehavior.AllowGet);
        }
    }
}