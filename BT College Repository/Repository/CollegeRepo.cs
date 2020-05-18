using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BT_College_Repository.IRepository;
using BT_Model;

namespace BT_College_Repository.Repository
{
   public class CollegeRepo : ICollegeRepo
    {
        public string Create()
        {
            return "Create Test";
        }
    }
}
