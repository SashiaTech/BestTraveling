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
    public class OperatorService : IOperatorService
    {
        private readonly IOperatorRepo _IOpretorRepo = null;
        public OperatorService()
        {
            _IOpretorRepo = new OperatorRepo();
        }
        public void AddOperator(string OperatorAddressXml,string OperatorDetailXml)
        {
            _IOpretorRepo.AddOperator(OperatorAddressXml,OperatorDetailXml);
        }

        public void DeleteOperator(OperatorModel model)
        {
            _IOpretorRepo.DeleteOperator(model);
        }

        public OperatorModel GetOperatorById(Guid OperatorId)
        {
            return _IOpretorRepo.GetOperatorById(OperatorId);
        }

        public IQueryable<OperatorModel> GetOperators()
        {
            return _IOpretorRepo.GetOperators();
        }

        public void UpdateOperator(OperatorModel model)
        {
            _IOpretorRepo.UpdateOperator(model);
        }
    }
}
