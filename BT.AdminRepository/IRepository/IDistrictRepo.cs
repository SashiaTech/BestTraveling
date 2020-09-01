using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_Model.AdminModel;
namespace BT.AdminRepository.IRepository
{
    public interface IDistrictRepo
    {
        IQueryable<DistrictModel> GetDistricts();
        DistrictModel GetDistrictById(Guid DistrictId);
        void AddDistrict(DistrictModel model);
        void UpdateDistrict(DistrictModel model);
        void RemoveDistrict(DistrictModel model);
    }
}
