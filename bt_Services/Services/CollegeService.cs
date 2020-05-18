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

namespace bt_Services.Services
{
    public class CollegeService : ICollegeService
    {
        ICollegeRepo _collegeRepo = null;

        public CollegeService()
        {
            _collegeRepo = new CollegeRepo();
        }

        public string Create()
        {
            return _collegeRepo.Create();
        }
    }
}
