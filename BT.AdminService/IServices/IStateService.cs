using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_Model.AdminModel;

namespace BT.AdminService.IServices
{
    public interface IStateService
    {
        IQueryable<StateModel> GetStates();
        StateModel GetStateById(Guid StateId);
        void AddState(StateModel model);
        void UpdateState(StateModel model);
        void RemoveState(StateModel model);
    }
}
