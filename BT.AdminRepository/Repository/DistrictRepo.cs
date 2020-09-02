using BT.AdminRepository.IRepository;
using BT_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_Data.BT_EDMX;
using BT.Repositories;

namespace BT.AdminRepository.Repository
{
    public class DistrictRepo : IDistrictRepo
    {
        private readonly GUnitWork gWork = null;
        public DistrictRepo()
        {
            gWork = new GUnitWork(new BestTravelingEntities());
        }
        public void AddDistrict(DistrictModel model)
        {
            bt_District Dist = new bt_District();
            Dist.DistrictId = model.DistrictId;
            Dist.Name = model.Name;
            Dist.Code = model.Code;
            Dist.IsActive = model.IsActive;
            Dist.IsDeleted = model.IsDeleted;
            Dist.StateId = model.StateId;
            Dist.CountryId = model.CountryId;
            Dist.CreatedBy = model.CreatedBy;
            Dist.CreatedDateTime = model.CreatedDateTime;
            gWork.Repository<bt_District>().Add(Dist);
            gWork.SaveChanges();
        }

        public DistrictModel GetDistrictById(Guid DistrictId)
        {
            var model = gWork.Repository<bt_District>().AsQuerable().Select(x => new DistrictModel {
                DistrictId = x.DistrictId,
                Name = x.Name,
                Code = x.Code,
                CountryId = x.CountryId,
                CountryName = x.bt_Country.Name,
                StateId = x.StateId,
                StateName  = x.bt_State.Name,
                IsActive = x.IsActive,
                IsDeleted = x.IsDeleted,

            }).FirstOrDefault(x=>x.DistrictId == DistrictId);
            return model;
        }

        public IQueryable<DistrictModel> GetDistricts()
        {
            var model = gWork.Repository<bt_District>().AsQuerable().Select(x => new DistrictModel
            {
                DistrictId = x.DistrictId,
                Name = x.Name,
                Code = x.Code,
                CountryId = x.CountryId,
                CountryName = x.bt_Country.Name,
                StateId = x.StateId,
                StateName = x.bt_State.Name,
                IsActive = x.IsActive,
                IsDeleted = x.IsDeleted,

            }).Where(x=>x.IsDeleted!=true);
            return model;
        }

        public void RemoveDistrict(Guid DistrictId)
        {
            bt_District dist = gWork.Repository<bt_District>().AsQuerable().FirstOrDefault(x=>x.DistrictId == DistrictId);
            gWork.Repository<bt_District>().Attach(dist);
            dist.IsDeleted = true;
            gWork.SaveChanges();
        }

        public void UpdateDistrict(DistrictModel model)
        {
            bt_District dist = gWork.Repository<bt_District>().AsQuerable().FirstOrDefault(x => x.DistrictId == model.DistrictId);
            gWork.Repository<bt_District>().Attach(dist);
            dist.DistrictId = model.DistrictId;
            dist.Name = model.Name;
            dist.Code = model.Code;
            dist.CountryId = model.CountryId;
            dist.StateId = model.StateId;
            dist.IsActive = model.IsActive;
            dist.ModifiedBy = model.ModifiedBy;
            gWork.SaveChanges();

        }
    }
}
