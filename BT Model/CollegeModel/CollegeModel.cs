using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Model
{
    public class CollegeModel
    {
        public Guid CollegeId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string DirectorName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
    }
}
