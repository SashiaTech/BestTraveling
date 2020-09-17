using BT_Model;
using bt_Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_College_Repository;
using BT_College_Repository.IRepository;
using BT_College_Repository.Repository;
using BT_Model.CollegeModel;

namespace bt_Services.Services
{
    public class CollegeService : ICollegeService
    {
        private readonly ICollegeRepo _collegeRepo = null;
        public CollegeService()
        {
            _collegeRepo = new CollegeRepo();
        }
        public void CreateCollege(CollegeModel model)
        {
            throw new NotImplementedException();
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
