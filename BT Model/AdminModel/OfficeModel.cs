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
        public string CityName { get; set; }
        public Guid? DistrictId { get; set; }
        public string DistrictName { get; set; }
        public Guid? CountryId { get; set; }
        public string CountryName { get; set; }
        public Guid? StateId { get; set; }
        public string StateName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public AddressModel AddressModel { get; set; }
    }
}
