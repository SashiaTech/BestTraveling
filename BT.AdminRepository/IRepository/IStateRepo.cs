using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_Model.AdminModel;
namespace BT.AdminRepository.IRepository
{
    public interface IStateRepo
    {
        IQueryable<StateModel> GetStates();
        StateModel GetStateById(Guid StateId);
        void AddState(StateModel stateModel);
        void UpdateState(StateModel stateModel);
        void RemoveState(StateModel model);
    }
}
