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
        public OfficeRepo()
        {
            gWork = new GUnitWork(new BestTravelingEntities());
        }
        public void AddOffice(OfficeModel model)
        {
            //bt_Office office = null;
            //office.OfficeId = model.OfficeId;
            //office.Name = model.Name;
            //office .
        }

        public void AddOfficeByXml(string OfficeAddressXml, string OfficeDetailXml)
        {
            using (var context = new BestTravelingEntities())
            {
                int test = context.usp_AddOffice(OfficeAddressXml,OfficeDetailXml);
            }
        }

        public void DeleteOffice(Guid OfficeId)
        {
            bt_Office office = gWork.Repository<bt_Office>().AsQuerable().FirstOrDefault(x => x.OfficeId == OfficeId);
            gWork.Repository<bt_Office>().Attach(office);
            office.IsDeleted = true;
            gWork.SaveChanges();
        }

        public OfficeModel GetOfficeById(Guid OfficeId)
        {
            var model = gWork.Repository<bt_Office>().AsQuerable().Select(x => new OfficeModel
            {
                OfficeId = x.OfficeId,
                Name = x.Name != null ? x.Name : "",
                Code = x.Code != null ? x.Code : "",
                AddressId = x.AddressId,
                Address1 = x.bt_Address.Address1 != null ? x.bt_Address.Address1 : "",
                Address2 = x.bt_Address.Address2 != null ? x.bt_Address.Address2 : "",
                Address3 = x.bt_Address.Address3 != null ? x.bt_Address.Address3 : "",
                CountryId = x.bt_Address.CountryId,
                StateId = x.bt_Address.StateId,
                DistrictId = x.bt_Address.DistrictId,
                CityId = x.bt_Address.CityId,
                IsActive = x.IsActive,
                IsDeleted = x.IsDeleted,
            }).FirstOrDefault(x => x.OfficeId == OfficeId);

            return model;
        }


        public IQueryable<OfficeModel> GetOffices()
        {
            var model = gWork.Repository<bt_Office>().AsQuerable().Select(x => new OfficeModel
            {
                OfficeId = x.OfficeId,
                Name = x.Name != null ? x.Name : "",
                Code = x.Code != null ? x.Code : "",
                AddressId = x.AddressId,
                Address1 = x.bt_Address.Address1 != null ? x.bt_Address.Address1 : "",
                Address2 = x.bt_Address.Address2 != null ? x.bt_Address.Address2 : "",
                Address3 = x.bt_Address.Address3 != null ? x.bt_Address.Address3 : "",
                CountryId = x.bt_Address.CountryId,
                CountryName = x.bt_Address.bt_Country.Name,
                StateId = x.bt_Address.StateId,
                StateName = x.bt_Address.bt_State.Name,
                CityId = x.bt_Address.CityId,
                CityName = x.bt_Address.bt_City.Name,
                DistrictId = x.bt_Address.DistrictId,
                DistrictName = x.bt_Address.bt_District.Name,
                IsActive = x.IsActive,
                IsDeleted = x.IsDeleted
            });
            return model;
        }

        public void UpdateOffice(OfficeModel model)
        {
            
            //bt_Office office = gWork.Repository<bt_Office>().AsQuerable().FirstOrDefault(x => x.OfficeId == model.OfficeId);
            //gWork.Repository<bt_Office>().Attach(office);
            //office.OfficeId = model.OfficeId;
            //office.Name = model.Name;

        }

        public void UpdateOfficeByXml(string OfficeAddressXml, string OfficeDetailXml)
        {
            using (var context = new BestTravelingEntities())
            {
                int i = context.usp_UpdateOffice(OfficeAddressXml, OfficeDetailXml);
            }
        }
    }
}
