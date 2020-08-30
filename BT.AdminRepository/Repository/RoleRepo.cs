using BT.AdminRepository.IRepository;
using BT.Repositories;
using BT_Data.BT_EDMX;
using BT_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT.AdminRepository.Repository
{
    public class RoleRepo : IRoleRepo
    {
        GUnitWork gWork = null;
        public RoleRepo()
        {
            gWork = new GUnitWork(new BestTravelingEntities());
        }
        public void AddRole(RoleModel model)
        {
            bt_Roles roleModel = new bt_Roles();
            roleModel.RoleId = model.RoleId;
            roleModel.Name = model.Name;
            roleModel.Description = model.Description;
            roleModel.Code = model.Code;
            roleModel.IsActive = model.IsActive;
            roleModel.IsDeleted = model.IsDeleted;
            gWork.Repository<bt_Roles>().Add(roleModel);
            gWork.SaveChanges();
        }

        public RoleModel GetRoleById(Guid RoleId)
        {
            var model = gWork.Repository<bt_Roles>().AsQuerable().Select(x=>new RoleModel {
                RoleId = x.RoleId,
                Name = x.Name,
                Code = x.Code,
                Description = x.Description,
                IsActive = x.IsActive,
                IsDeleted = x.IsDeleted
            }).FirstOrDefault(x => x.RoleId == RoleId);
            return model;
        }

        public IQueryable<RoleModel> GetRoles()
        {
            var model = gWork.Repository<bt_Roles>().AsQuerable().Select(x => new RoleModel {
                RoleId = x.RoleId,
                Name = x.Name,
                Code = x.Code,
                Description = x.Description,
                IsActive = x.IsActive,
                IsDeleted = x.IsDeleted,
            });
            return model;
        }

        public void RemoveRole(RoleModel model)
        {
            var RoleRec = gWork.Repository<bt_Roles>().AsQuerable().FirstOrDefault(x=>x.RoleId == model.RoleId);
            gWork.Repository<bt_Roles>().Attach(RoleRec);
            RoleRec.RoleId = model.RoleId;
            RoleRec.Name = model.Name;
            RoleRec.Description = model.Description;
            RoleRec.Code = model.Code;
            RoleRec.IsActive = model.IsActive;
            RoleRec.IsDeleted = model.IsDeleted;
            gWork.SaveChanges();
        }

        public void UpdateRole(RoleModel model)
        {
            var RoleRec = gWork.Repository<bt_Roles>().AsQuerable().FirstOrDefault(x => x.RoleId == model.RoleId);
            gWork.Repository<bt_Roles>().Attach(RoleRec);
            RoleRec.RoleId = model.RoleId;
            RoleRec.Name = model.Name;
            RoleRec.Description = model.Description;
            RoleRec.Code = model.Code;
            RoleRec.IsActive = model.IsActive;
            RoleRec.IsDeleted = model.IsDeleted;
            gWork.SaveChanges();
        }
    }
}
