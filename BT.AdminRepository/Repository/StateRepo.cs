using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_Model.AdminModel;
using BT.AdminRepository.IRepository;
using BT.Repositories;
using BT_Data.BT_EDMX;

namespace BT.AdminRepository.Repository
{
    public class StateRepo : IStateRepo
    {
        GUnitWork gwork = null;

        public StateRepo()
        {
            gwork = new BestTravelingEntities();
        }
        public void AddState(StateModel stateModel)
        {
            bt_State state = new bt_State();
            state.StateId = stateModel.StateId;
            state.Name = stateModel.Name;
            state.Code = stateModel.Code;
            state.CountryId = stateModel.CountryId;
            gwork.Repository<bt_State>().Add(state);
            gwork.SaveChanges();
        }

        public StateModel GetStateById(Guid StateId)
        {
            var State = (from x in gwork.Repository<bt_State>().AsQuerable()
                         select new StateModel
                         {
                             StateId = x.StateId,
                             Name = x.Name,
                             Code = x.Code,
                             CountryId = x.CountryId,
                             CountryName = x.bt_Country.Name
                         }).FirstOrDefault(x=>x.StateId == StateId);
            return State;
        }

        public IQueryable<StateModel> GetStates()
        {
            var States = (from x in gwork.Repository<bt_State>().AsQuerable()
                          select new StateModel {
                              StateId = x.StateId,
                              Name = x.Name,
                              Code = x.Code,
                              CountryId = x.CountryId,
                              CountryName = x.bt_Country.Name
                          });
            return States;
        }

        public void RemoveState(Guid stateId)
        {
            throw new NotImplementedException();
        }

        public void UpdateState(StateModel stateModel)
        {
            bt_State state = gwork.Repository<bt_State>().AsQuerable().FirstOrDefault(x=>x.StateId == stateModel.StateId);
            gwork.Repository<bt_State>().Attach(state);
            state.StateId = stateModel.StateId;
            state.Name = stateModel.Name;
            state.Code = stateModel.Code;
            state.CountryId = stateModel.CountryId;
            gwork.SaveChanges();
        }
    }
}
