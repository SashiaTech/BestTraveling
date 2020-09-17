using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_Model;
using BT_Model.CollegeModel;

namespace bt_Services.IServices
{
    public interface ICollegeService
    {
        IQueryable<CollegeModel> GetColleges();
        CollegeModel GetCollegeById(Guid CollegeModel);
        void CreateCollege(CollegeModel model);
        void UpdateCollege(CollegeModel model);
        void DeleteCollege(Guid CollegeId);
    }
}
