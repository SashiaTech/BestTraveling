using BT_Model.AdminModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT.AdminService.IServices
{
    public interface IDesignationService
    {
        IQueryable<DesignationModel> GetDesgnations();
        DesignationModel GetDesignationById(Guid DesignationId);
        void AddDesignation(DesignationModel model);
        void UpdateDesignation(DesignationModel model);
        void DeleteDesignation(Guid DesignationId);
    }
}
