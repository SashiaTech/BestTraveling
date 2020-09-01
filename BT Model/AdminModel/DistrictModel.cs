using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Model.AdminModel
{
    public class DistrictModel
    {
        public Guid DistrictId { get; set; }
        public String Name { get; set; }
        public string Code { get; set; }
        public Guid? StateId { get; set; }
        public string StateName { get; set; }
        public Guid? CountryId { get; set; }
        public string CountryName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public Guid? ModifiedBy { get; set; }
    }
}
