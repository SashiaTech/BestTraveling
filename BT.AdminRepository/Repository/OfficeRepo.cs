using BT.AdminRepository.IRepository;
using BT_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT.Repositories;
using BT_Data.BT_EDMX;

namespace BT.AdminRepository.Repository
{
    public class OfficeRepo : IOfficeRepo
    {
        private GUnitWork gWork = null;
        public void AddOffice(OfficeModel model)
        {
            //bt_Office office = null;
            //office.OfficeId = model.OfficeId;
            //office.Name = model.Name;
            //office .
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
