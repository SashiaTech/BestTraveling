using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Model.AdminModel
{
    public class OfficeModel
    {
        public Guid OfficeId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid? AddressId { get; set; }
        public Guid? CityId { get; set; }
        public Guid? DistrictId { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? StateId { get; set; }
        public AddressModel AddressModel { get; set; }
    }
}
