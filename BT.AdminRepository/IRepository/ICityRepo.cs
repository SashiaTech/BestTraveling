using BT_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT.AdminRepository.IRepository
{
    public interface ICityRepo
    {
        IQueryable<CityModel> GetCitis();
        CityModel GetCityById(Guid CityId);
        void AddCity(CityModel model);
        void UpdateCity(CityModel model);
        void RemoveCity(CityModel model);
    }
}
