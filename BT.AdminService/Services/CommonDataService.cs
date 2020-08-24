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
        public CommonDataService()
        {
            _ICountryRepo = new CountryRepo();
        }

        public IQueryable<CountryModel> GetCountries()
        {
            return _ICountryRepo.GetCountries();
        }

        public IQueryable<StateModel> GetStates()
        {
            throw new NotImplementedException();
        }
    }
}
