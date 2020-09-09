using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_Model.AdminModel;


namespace BT.AdminService.IServices
{
    public interface IOperatorService
    {
        IQueryable<OperatorModel> GetOperators();
        OperatorModel GetOperatorById(Guid OperatorId);
        void AddOperator(string OperatorAddressXml, string OperatorDetailXml);
        void UpdateOperator(OperatorModel model);
        void DeleteOperator(OperatorModel model);
    }
}
