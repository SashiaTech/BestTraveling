using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_College_Repository.IRepository;
using BT_Model.CollegeModel;
using BT_Data.BT_EDMX;
using BT.Repositories;

namespace BT_College_Repository.Repository
{
    public class CollegeRepo : ICollegeRepo
    {
        GUnitWork gWork = null;
        public CollegeRepo()
        {
            gWork = new GUnitWork(new BestTravelingEntities());
        }

        public void CreateCollege(CollegeModel model)
        {
            //bt_College college = new bt_College();
            //college.CollegeId = model.CollegeId;
            //college.Name = model.Name;
            //college.Code = model.Code;
            //college.
        }

        public void DeleteCollege(Guid CollegeId)
        {
            throw new NotImplementedException();
        }

        public CollegeModel GetCollegeById(Guid CollegeModel)
        {
            throw new NotImplementedException();
        }

        public IQueryable<CollegeModel> GetColleges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCollege(CollegeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
