using BT.AdminService.IServices;
using BT_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT.AdminRepository.IRepository;
using BT.AdminRepository.Repository;

namespace BT.AdminService.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepo _ICountryRepo = null;
        public CountryService()
        {
            _ICountryRepo = new CountryRepo();
        }
        public void AddCountry(CountryModel model)
        {
            _ICountryRepo.AddCountry(model);
        }

        public IQueryable<CountryModel> GetCountries()
        {
             return _ICountryRepo.GetCountries();
        }

        public CountryModel GetCountryById(Guid CountryId)
        {
            var model = _ICountryRepo.GetCountryById(CountryId);
            return model;
        }

        public void RemoveCountry(Guid CountryId)
        {
            _ICountryRepo.RemoveCountry(CountryId);
        }
    }
}
