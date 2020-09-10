using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Model.AdminModel
{
    public class OperatorModel
    {
        public Guid OperatorId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Contact { get; set; }
        public Guid DesignationId { get; set; }
        public string Address { get; set; }
        public Guid? CountryId { get; set; }
        public string Country { get; set; }
        public Guid? StateId { get; set; }
        public string State { get; set; }
        public Guid? CityId { get; set; }
        public string City { get; set; }
        public Guid? DistrictId { get; set; }
        public string District { get; set; }
        public Guid Createdby { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public Guid? AddressId { get; set; }
        public Guid? GenderId { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
    }
}
