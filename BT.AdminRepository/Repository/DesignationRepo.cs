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
    public class DesignationRepo : IDesignationRepo
    {
        private GUnitWork gWork = null;
        public DesignationRepo()
        {
            gWork =new GUnitWork(new BestTravelingEntities());
        }
        public void AddDesignation(DesignationModel model)
        {
            bt_Designation designation = new bt_Designation();
            designation.DesignationId = model.DesignationId;
            designation.Name = model.Name;
            designation.Code = model.Code;
            designation.CreatedBy = model.CreatedBy;
            designation.CreatedDateTime = model.CreatedDateTime;
            gWork.Repository<bt_Designation>().Add(designation);
            gWork.SaveChanges();
        }

        public void DeleteDesignation(Guid DesignationId)
        {
            bt_Designation model = gWork.Repository<bt_Designation>().AsQuerable().FirstOrDefault(x=>x.DesignationId == DesignationId);
            gWork.Repository<bt_Designation>().Attach(model);
            model.IsDeleted = true;
            gWork.SaveChanges();
        }

        public IQueryable<DesignationModel> GetDesgnations()
        {
            var model = gWork.Repository<bt_Designation>().AsQuerable().Where(x=>x.IsDeleted==!true).Select(x=>new DesignationModel {
                DesignationId = x.DesignationId,
                Name = x.Name,
                Code = x.Code,
                CreatedBy = x.CreatedBy,
                CreatedDateTime = x.CreatedDateTime,
                IsDeleted = x.IsDeleted,
                
            });
            return model;
        }

        public DesignationModel GetDesignationById(Guid DesignationId)
        {
            var model = gWork.Repository<bt_Designation>().AsQuerable().Select(x=>new DesignationModel {
                DesignationId = x.DesignationId,
                Name = x.Name,
                Code = x.Code,
                CreatedBy = x.CreatedBy,
                CreatedDateTime = x.CreatedDateTime,
                IsDeleted = x.IsDeleted,
            }).FirstOrDefault(x => x.DesignationId == DesignationId);
            return model;
        }

        public void UpdateDesignation(DesignationModel model)
        {
            bt_Designation desg = gWork.Repository<bt_Designation>().AsQuerable().FirstOrDefault(x => x.DesignationId == model.DesignationId);
            gWork.Repository<bt_Designation>().Attach(desg);
            desg.DesignationId = model.DesignationId;
            desg.Name = model.Name;
            desg.Code = model.Code;
            desg.IsDeleted = model.IsDeleted;
            gWork.SaveChanges();
        }
    }
}
