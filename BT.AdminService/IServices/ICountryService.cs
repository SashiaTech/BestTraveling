using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_Model.AdminModel;

namespace BT.AdminService.IServices
{
    public interface ICountryService
    {
        void AddCountry(CountryModel model);
        IQueryable<CountryModel> GetCountries();
        CountryModel GetCountryById(Guid CountryId);
        void RemoveCountry(Guid CountryId);
        void UpdateCountry(CountryModel model);
    }
}
