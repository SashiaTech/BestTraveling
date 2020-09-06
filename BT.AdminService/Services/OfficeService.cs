using BT.AdminRepository.IRepository;
using BT.AdminService.IServices;
using BT_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT.AdminRepository.Repository;


namespace BT.AdminService.Services
{
    public class OfficeService : IOfficeService
    {
        private readonly IOfficeRepo _IOfficeRepo = null;
        public OfficeService()
        {
            _IOfficeRepo = new OfficeRepo();
        }
        public void AddOffice(OfficeModel model)
        {
            _IOfficeRepo.AddOffice(model);
        }

        public void AddOfficeByXml(string OfficeAddressXml, string OfficeDetailXml)
        {
            _IOfficeRepo.AddOfficeByXml(OfficeAddressXml,OfficeDetailXml);
        }

        public void DeleteOffice(Guid OfficeId)
        {
            _IOfficeRepo.DeleteOffice(OfficeId);
        }

        public OfficeModel GetOfficeById(Guid OfficeId)
        {
            return _IOfficeRepo.GetOfficeById(OfficeId);
        }

        public IQueryable<OfficeModel> GetOffices()
        {
            return _IOfficeRepo.GetOffices();
        }

        public void UpdateOffice(OfficeModel model)
        {
            _IOfficeRepo.UpdateOffice(model);
        }

        public void UpdateOfficeByXml(string OfficeAddressXml, string OfficeDetailXml)
        {
            _IOfficeRepo.UpdateOfficeByXml(OfficeAddressXml,OfficeDetailXml);
        }
    }
}
