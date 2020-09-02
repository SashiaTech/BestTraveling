using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_Model.AdminModel;

namespace BT.AdminService.IServices
{
    public interface IDistrictService
    {
        IQueryable<DistrictModel> GetDistricts();
        DistrictModel GetDistrictById(Guid DistrictId);
        void AddDistrict(DistrictModel model);
        void UpdateDistrict(DistrictModel model);
        void RemoveDistrict(Guid District);

    }
}
