//ICityService

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_Model;

namespace BT.AdminService.IServices
{
    public interface ICityService
    {
        IQueryable<CityModel> GetCitis();
        CityModel GetCityById(Guid CityId);
        void AddCity(CityModel model);
        void UpdateCity(CityModel model);
        void RemoveCity(CityModel model);
    }
}
