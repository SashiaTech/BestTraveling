using BT.AdminRepository.IRepository;
using BT.AdminService.IServices;
using BT_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BT.AdminService.Services
{
    public class OfficeService : IOfficeService
    {
        public void AddOffice(OfficeModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteOffice(Guid OfficeId)
        {
            throw new NotImplementedException();
        }

        public OfficeModel GetOfficeId(Guid OfficeId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<OfficeModel> GetOffices()
        {
            throw new NotImplementedException();
        }

        public void UpdateOffice(OfficeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
