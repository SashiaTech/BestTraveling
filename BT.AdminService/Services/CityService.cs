//CityService

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT.AdminService.IServices;
using BT_Model.AdminModel;
using BT.AdminRepository.IRepository;
using BT.AdminRepository.Repository;


namespace BT.AdminService.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepo _ICityRepo = null;
        public CityService()
        {
            this._ICityRepo = new CityRepo();
        }
        public void AddCity(CityModel model)
        {
            _ICityRepo.AddCity(model);
        }

        public IQueryable<CityModel> GetCitis()
        {
            return _ICityRepo.GetCitis();
        }

        public CityModel GetCityById(Guid CityId)
        {
            return _ICityRepo.GetCityById(CityId);
        }

        public void RemoveCity(CityModel model)
        {
            _ICityRepo.RemoveCity(model);
        }

        public void UpdateCity(CityModel model)
        {
            _ICityRepo.UpdateCity(model);
        }
    }
}
