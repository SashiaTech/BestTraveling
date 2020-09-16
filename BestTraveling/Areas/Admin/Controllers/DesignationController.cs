using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BT_Model.AdminModel;
using BT.AdminService.IServices;
namespace BestTraveling.Areas.Admin.Controllers
{
    public class DesignationController : Controller
    {
        private readonly IDesignationService _DesignationServices = null;
        public DesignationController(IDesignationService _DesignationServices)
        {
            this._DesignationServices = _DesignationServices;
        }
        // GET: Admin/Designation
        public ActionResult List()
        {
            return View();
        }

        public JsonResult Designation_Read()
        {
            var Designation = _DesignationServices.GetDesgnations();
            return Json(Designation, JsonRequestBehavior.AllowGet);
        }
        public ActionResult AddDesignation()
        {
            return PartialView("~/Areas/Admin/Views/Designation/_AddDesignation.cshtml", new DesignationModel());
        }

        [HttpPost]
        public ActionResult AddDesignation(DesignationModel model)
        {
            bool flag = false;
            try
            {
                model.DesignationId = Guid.NewGuid();
                _DesignationServices.AddDesignation(model);
                flag = true;
            }
            catch (Exception ex)
            {

                flag = false;
            }
            Designation_Read();
            return Json(flag);
            
        }


        public ActionResult UpdateDesignation(Guid DesignationId)
        {
            DesignationModel designation = null;
            try
            {
                designation = _DesignationServices.GetDesignationById(DesignationId);
                return PartialView("~/Areas/Admin/Views/Designation/_UpdateDesignation.cshtml", designation);
            }
            catch(Exception ex)
            {

            }

            return PartialView("~/Areas/Admin/Views/Designation/_UpdateDesignation.cshtml", designation);
            
        }

        [HttpPost]

        public ActionResult UpdateDesignation(DesignationModel model)
        {
            bool flag = false;
            try
            {
                _DesignationServices.UpdateDesignation(model);
                flag = true;
            }
            catch (Exception ex)
            {

                flag = false;
            }
            return Json(flag, JsonRequestBehavior.AllowGet);
        }

     
        public JsonResult DeleteDesignation(Guid DesignationId)
        {
            bool flag = false;
            try
            {
                _DesignationServices.DeleteDesignation(DesignationId);
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