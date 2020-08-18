using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_Model.AdminModel;

namespace BT.AdminRepository.IRepository
{
    public interface ICountryRepo
    {
        IQueryable<CountryModel> GetCountries();
        CountryModel GetCountryById(Guid CountryId);
        void AddCountry(CountryModel model);
        void UpdateCountry(CountryModel model);
        void RemoveCountry(Guid CountryId);

    }
}
