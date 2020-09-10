using BT.AdminService.IServices;
using BT_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT.AdminRepository.IRepository;
using BT.AdminRepository.Repository;


namespace BT.AdminService.Services
{
    public class DesignationService : IDesignationService
    {
        private readonly IDesignationRepo _IDesignationRepo = null;
        public DesignationService()
        {
            _IDesignationRepo = new DesignationRepo();
        }

        public void AddDesignation(DesignationModel model)
        {
            _IDesignationRepo.AddDesignation(model);
        }

        public void DeleteDesignation(Guid DesignationId)
        {
            _IDesignationRepo.DeleteDesignation(DesignationId);
        }

        public IQueryable<DesignationModel> GetDesgnations()
        {
            return _IDesignationRepo.GetDesgnations();
        }

        public DesignationModel GetDesignationById(Guid DesignationId)
        {
            return _IDesignationRepo.GetDesignationById(DesignationId);
        }

        public void UpdateDesignation(DesignationModel model)
        {
            _IDesignationRepo.UpdateDesignation(model);
        }
    }
}
