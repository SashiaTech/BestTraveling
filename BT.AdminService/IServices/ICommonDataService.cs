using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_Model.AdminModel;

namespace BT.AdminService.IServices
{
    public interface ICommonDataService
    {
        IQueryable<StateModel> GetStates();
        IQueryable<CountryModel> GetCountries();
        IQueryable<DistrictModel> GetDistricts();
        IQueryable<CityModel> GetCities();


    }
}
