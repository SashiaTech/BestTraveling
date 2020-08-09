using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Model.AdminModel
{
    public class StateModel
    {
        public Guid StateId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid? CountryId { get; set; }
        public string CountryName { get; set; }
    }
}
