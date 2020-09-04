using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_Model.AdminModel;

namespace BT.AdminService.IServices
{
    public interface IOfficeService
    {
        IQueryable<OfficeModel> GetOffices();
        OfficeModel GetOfficeId(Guid OfficeId);
        void AddOffice(OfficeModel model);
        void UpdateOffice(OfficeModel model);
        void DeleteOffice(Guid OfficeId);
    }
}
