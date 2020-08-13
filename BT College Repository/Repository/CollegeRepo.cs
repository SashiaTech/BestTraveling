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
        GUnitWork gWork = new GUnitWork(new BestTravelingEntities());
        BestTravelingEntities db = new BestTravelingEntities();
        public string Create()
        {
            return "Create Test";
        }

        public void Create(CollegeModel college)
        {
        }
    }
}
