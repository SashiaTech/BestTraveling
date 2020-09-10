using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_Model.AdminModel;
namespace BT.AdminRepository.IRepository
{
    public interface IDesignationRepo
    {
        IQueryable<DesignationModel> GetDesgnations();
        DesignationModel GetDesignationById(Guid DesignationId);
        void AddDesignation(DesignationModel model);
        void UpdateDesignation(DesignationModel model);
        void DeleteDesignation(Guid DesignationId);
    }
}
