using BT_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT.AdminRepository.IRepository
{
    public interface IOperatorRepo
    {
        IQueryable<OperatorModel> GetOperators();
        OperatorModel GetOperatorById(Guid OperatorId);
        void AddOperator(OperatorModel model);
        void UpdateOperator(OperatorModel model);
        void DeleteOperator(OperatorModel model);
    }
}
