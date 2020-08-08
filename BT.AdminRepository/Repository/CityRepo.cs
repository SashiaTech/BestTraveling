//CityRepo

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT.AdminRepository.IRepository;
using BT.Repositories;
using BT_Data.BT_EDMX;
using BT_Model;


namespace BT.AdminRepository.Repository
{
    public class CityRepo : ICityRepo
    {
        GUnitWork gWork = null;
        public CityRepo()
        {
            gWork = new BestTravelingEntities();

        }
        public void AddCity(CityModel model)
        {
            bt_City city = new bt_City();
            city.CityId = model.CityId;
            city.Name = model.Name;
            city.Code = model.Code;
            city.DistrictId = model.DistrictId;
            gWork.Repository<bt_City>().Add(city);
            gWork.SaveChanges();
        }

        public IQueryable<CityModel> GetCitis()
        {
            var cities = (from cts in gWork.Repository<bt_City>().AsQuerable()
                          select new CityModel
                          {
                              CityId = cts.CityId,
                              Name = cts.Name,
                              DistrictId = cts.DistrictId,
                              DistrictName = cts.bt_District.Name,
                              Code = cts.Code,
                          });
            return cities;
        }

        public CityModel GetCityById(Guid CityId)
        {
            var cities = (from x in gWork.Repository<bt_City>().AsQuerable()
                          select new CityModel
                          {
                              CityId = x.CityId,
                              Name = x.Name,
                              Code = x.Code,
                              DistrictId = x.DistrictId,
                              DistrictName = x.bt_District.Name,
                          }).FirstOrDefault(x => x.CityId == CityId);
            return cities;
        }

        public void RemoveCity(CityModel model)
        {
            bt_City City = gWork.Repository<bt_City>().AsQuerable().FirstOrDefault(x => x.CityId == model.CityId);
            gWork.Repository<bt_City>().Attach(City);
            City.IsDeleted = true;
            gWork.SaveChanges();
        }

        public void UpdateCity(CityModel model)
        {
            bt_City City = gWork.Repository<bt_City>().AsQuerable().FirstOrDefault(x => x.CityId == model.CityId);
            gWork.Repository<bt_City>().Attach(City);
            City.CityId = model.CityId;
            City.Name = model.Name;
            City.Code = model.Code;
            City.DistrictId = model.DistrictId;
            gWork.SaveChanges();


        }
    }
}
