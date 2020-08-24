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
    public class StateService : IStateService
    {
        private readonly IStateRepo _IStateRepo = null;
        public StateService()
        {
            _IStateRepo = new StateRepo();
        }
        public void AddState(StateModel model)
        {
            _IStateRepo.AddState(model);
        }

        public StateModel GetStateById(Guid StateId)
        {
            return _IStateRepo.GetStateById(StateId);
        }

        public IQueryable<StateModel> GetStates()
        {
            return _IStateRepo.GetStates();
        }

        public void RemoveState(StateModel model)
        {
            _IStateRepo.RemoveState(model);
        }

        public void UpdateState(StateModel model)
        {
            _IStateRepo.UpdateState(model);
        }
    }
}
