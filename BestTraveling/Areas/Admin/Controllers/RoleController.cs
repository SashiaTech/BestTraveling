using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BT.AdminService.IServices;
using BT_Model.AdminModel;

namespace BestTraveling.Areas.Admin.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService _IRoleService = null;
        public RoleController(IRoleService _IRoleService)
        {
            this._IRoleService = _IRoleService;
        }
        // GET: Admin/Role
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Read_Role()
        {
           var model = _IRoleService.GetRoles();
            var test = model.ToList();
            return Json(model,JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddRole()
        {
            return PartialView("~/Areas/Admin/Views/Role/_AddRole.cshtml");
        }

        [HttpPost]
        public ActionResult AddRole(RoleModel model)
        {
            bool flag = false;
            try
            {
                model.RoleId = Guid.NewGuid();
                _IRoleService.AddRole(model);
                flag = true;
            }
            catch(Exception ex)
            {
                flag = false;
            }
            
            return Json(flag,JsonRequestBehavior.AllowGet);
            
        }


        public ActionResult UpdateRole(Guid RoleId)
        {
            var model = _IRoleService.GetRoleById(RoleId);
            return PartialView("~/Areas/Admin/Views/Role/_UpdateRole.cshtml",model);
        }

        [HttpPost]
        public ActionResult UpdateRole(RoleModel model)
        {
            bool flag = false;
            try
            {
                _IRoleService.UpdateRole(model);
                flag = true;
            }
            catch(Exception ex)
            {
                flag = false;
            }
            
            return Json(flag,JsonRequestBehavior.AllowGet);
        }

        public ActionResult RemoveRole(Guid RoleId)
        {
            bool flag = false;
            try
            {
                var model = _IRoleService.GetRoleById(RoleId);
                model.IsDeleted = true;
                _IRoleService.RemoveRole(model);
                flag = true;
            }
            catch(Exception ex)
            {
                flag = false;
            }
            return Json(flag, JsonRequestBehavior.AllowGet);
        }
    }
}