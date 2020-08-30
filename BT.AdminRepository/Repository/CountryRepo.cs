using BT.AdminRepository.IRepository;
using BT.Repositories;
using BT_Data.BT_EDMX;
using BT_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using BT.Repositories;
/*using BT_Data.BT_EDMX*/
//using BT_Model;


namespace BT.AdminRepository.Repository
{
    public class CountryRepo : ICountryRepo
    {
        GUnitWork gWork = null;
        public CountryRepo()
        {
            gWork = new GUnitWork(new BestTravelingEntities());
        }

        public void AddCountry(CountryModel model)
        {
            bt_Country country = new bt_Country();
            country.CountryId = model.CountryId;
            country.Name = model.Name;
            country.Code = model.Code;
            gWork.Repository<bt_Country>().Add(country);
            gWork.SaveChanges();
        }

        public IQueryable<CountryModel> GetCountries()
        {
           var model = (from x in gWork.Repository<bt_Country>().AsQuerable()
             select new CountryModel
             {
                 CountryId = x.CountryId,
                 Name = x.Name,
                 Code = x.Code,
                 IsDeleted = x.IsDeleted
             });
            var test = model.ToList();
            return model;
        }

        public CountryModel GetCountryById(Guid CountryId)
        {
            var model = (from x in gWork.Repository<bt_Country>().AsQuerable().Where(x => x.CountryId == CountryId)
                         select new CountryModel {
                             CountryId = x.CountryId,
                             Name = x.Name,
                             Code = x.Code,
                         }).FirstOrDefault();
            return model;
        }

        public void RemoveCountry(Guid CountryId)
        {
            bt_Country model =  gWork.Repository<bt_Country>().AsQuerable().FirstOrDefault(x=>x.CountryId == CountryId);
            if (model != null)
            {
                gWork.Repository<bt_Country>().Delete(model);
            }
        }

        public void UpdateCountry(CountryModel model)
        {
            bt_Country country = gWork.Repository<bt_Country>().AsQuerable().FirstOrDefault(x=>x.CountryId == model.CountryId);
            if (country != null)
            {
                gWork.Repository<bt_Country>().Attach(country);
                country.Name = model.Name;
                country.Code = model.Code;
                gWork.SaveChanges();
            }
        }
    }
}
