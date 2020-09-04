using BT.AdminService.IServices;
using BT_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT.AdminRepository.Repository;
using BT.AdminRepository.IRepository;

namespace BT.AdminService.Services
{
    public class CommonDataService : ICommonDataService
    {
        private readonly  ICountryRepo _ICountryRepo = null;
        private readonly IStateRepo _IStateRepo = null;
        private readonly IDistrictRepo _IDistrictRepo = null;
        private readonly ICityRepo _ICityRepo = null;
        public CommonDataService()
        {
            _ICountryRepo = new CountryRepo();
            _IStateRepo = new StateRepo();
            _IDistrictRepo = new DistrictRepo();
            _ICityRepo = new CityRepo();
        }

        public IQueryable<CountryModel> GetCountries()
        {
            return _ICountryRepo.GetCountries();
        }

        public IQueryable<StateModel> GetStates()
        {
            return _IStateRepo.GetStates();
        }

        public IQueryable<DistrictModel> GetDistricts()
        {
            return _IDistrictRepo.GetDistricts();
        }

        public IQueryable<CityModel> GetCities()
        {
            return _ICityRepo.GetCitis();
        }
    }
}
