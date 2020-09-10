using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Model.AdminModel
{
    public class DesignationModel
    {
        public Guid DesignationId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
