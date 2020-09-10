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
    public class OperatorRepo : IOperatorRepo
    {
        GUnitWork gWork = null;        
        public OperatorRepo()
        {
            gWork = new GUnitWork(new BestTravelingEntities());
        }
        public void AddOperator(string OperatorAddressXml,string OperatorDetailXml)
        {
            using (var context = new BestTravelingEntities())
            {
                int res = context.usp_AddOperator(OperatorDetailXml, OperatorAddressXml);
            }
        }

        public void DeleteOperator(OperatorModel model)
        {
            bt_OfficeOperator rec = gWork.Repository<bt_OfficeOperator>().AsQuerable().FirstOrDefault(x => x.OperatorId == model.OperatorId);
            gWork.Repository<bt_OfficeOperator>().Attach(rec);
            rec.IsDeleted = true;
            gWork.SaveChanges();
        }

        public OperatorModel GetOperatorById(Guid OperatorId)
        {
            var model = gWork.Repository<bt_OfficeOperator>().AsQuerable().Select(x=>new OperatorModel {
                OperatorId = x.OperatorId,
                Name = x.Name,
                Code = x.Code,
                AddressId = x.AddressId,
                Address = x.bt_Address.Address1,
                CountryId = x.bt_Address.CountryId,
                Country = x.bt_Address.bt_Country.Name,
                StateId = x.bt_Address.StateId,
                State = x.bt_Address.bt_State.Name,
                DistrictId = x.bt_Address.DistrictId,
                District = x.bt_Address.bt_District.Name,
                IsDeleted = x.IsDeleted,
            }).FirstOrDefault(x=>x.OperatorId == OperatorId);
            return model;
        }

        public IQueryable<OperatorModel> GetOperators()
        {
            var model = gWork.Repository<bt_OfficeOperator>().AsQuerable().Select(x=>new OperatorModel {
                OperatorId = x.OperatorId,
                Name = x.Name,
                Code=x.Code,
                AddressId = x.AddressId,
                Address = x.bt_Address.Address1,
                CountryId = x.bt_Address.CountryId,
                Country = x.bt_Address.bt_Country.Name,
                StateId = x.bt_Address.StateId,
                State = x.bt_Address.bt_State.Name,
                DistrictId = x.bt_Address.DistrictId,
                District = x.bt_Address.bt_District.Name,
                IsDeleted = x.IsDeleted,
                Gender = x.bt_Gender.Name,
                Designation = x.bt_Designation.Name,
            }).Where(x=>x.IsDeleted!=true);
            return model;
        }

        public void UpdateOperator(OperatorModel model)
        {
            throw new NotImplementedException();
        }
    }
}
