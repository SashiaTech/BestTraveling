using BT_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_Model.CollegeModel;

namespace BT_College_Repository.IRepository
{
    public interface ICollegeRepo
    {
        IQueryable<CollegeModel> GetColleges();
        CollegeModel GetCollegeById(Guid CollegeModel);
        void CreateCollege(CollegeModel model);
        void UpdateCollege(CollegeModel model);
        void DeleteCollege(Guid CollegeId);
    }
}
