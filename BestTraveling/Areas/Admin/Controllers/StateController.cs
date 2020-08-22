using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BT.AdminService.IServices;

namespace BestTraveling.Areas.Admin.Controllers
{
    public class StateController : Controller
    {
        private readonly IStateService _IStateService = null;
        // GET: Admin/State
        public StateController(IStateService _IStateService)
        {
            this._IStateService = _IStateService;
        }

        public ActionResult List()
        {
            return View();
        }

        public ActionResult State_Read()
        {
            var model = _IStateService.GetStates();
            return Json(model,JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddState()
        {
            return PartialView("~/Areas/Admin/Views/State/_AddState.cshtml");
        }
    }
}