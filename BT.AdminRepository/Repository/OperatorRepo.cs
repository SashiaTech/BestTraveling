using BT.AdminRepository.IRepository;
using BT_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT.Repositories;
using BT_Data.BT_EDMX;

namespace BT.AdminRepository.Repository
{
    public class OperatorRepo : IOperatorRepo
    {
        GUnitWork gWork = null;        
        public OperatorRepo()
        {
            gWork = new GUnitWork(new BestTravelingEntities());
        }
        public void AddOperator(OperatorModel model)
        {
            
        }

        public void DeleteOperator(OperatorModel model)
        {
            throw new NotImplementedException();
        }

        public OperatorModel GetOperatorById(Guid OperatorId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<OperatorModel> GetOperators()
        {
            throw new NotImplementedException();
        }

        public void UpdateOperator(OperatorModel model)
        {
            throw new NotImplementedException();
        }
    }
}
