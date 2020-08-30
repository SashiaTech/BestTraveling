using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT.AdminRepository.IRepository;
using BT.AdminRepository.Repository;
using BT.AdminService.IServices;
using BT_Model.AdminModel;

namespace BT.AdminService.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepo _IRoleRepo=null;
        public RoleService()
        {
            _IRoleRepo = new RoleRepo();
        }
        public void AddRole(RoleModel model)
        {
            _IRoleRepo.AddRole(model);
        }

        public RoleModel GetRoleById(Guid RoleId)
        {
            return _IRoleRepo.GetRoleById(RoleId);
        }

        public IQueryable<RoleModel> GetRoles()
        {
            return _IRoleRepo.GetRoles();
        }

        public void RemoveRole(RoleModel model)
        {
            _IRoleRepo.RemoveRole(model);
        }

        public void UpdateRole(RoleModel model)
        {
            _IRoleRepo.UpdateRole(model);
        }
    }
}
