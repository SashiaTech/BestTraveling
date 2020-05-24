using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Model
{
    public class CityModel
    {
        public Guid CityId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid? DistrictId{ get; set; }
        
    }
}
