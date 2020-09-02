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
    public class DistrictService : IDistrictService
    {
        private readonly IDistrictRepo _IDistrictRepo = null;
        public DistrictService()
        {
            _IDistrictRepo = new DistrictRepo();
        }
        public void AddDistrict(DistrictModel model)
        {
            _IDistrictRepo.AddDistrict(model);            
        }

        public DistrictModel GetDistrictById(Guid DistrictId)
        {
            return _IDistrictRepo.GetDistrictById(DistrictId);
        }

        public IQueryable<DistrictModel> GetDistricts()
        {
            return _IDistrictRepo.GetDistricts();
        }

        public void RemoveDistrict(Guid DistrictId)
        {
            _IDistrictRepo.RemoveDistrict(DistrictId);
        }

        public void UpdateDistrict(DistrictModel model)
        {
            _IDistrictRepo.UpdateDistrict(model);
        }
    }
}
