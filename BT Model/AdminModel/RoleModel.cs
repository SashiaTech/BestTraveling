using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Model.AdminModel
{
    public class RoleModel
    {
        public Guid RoleId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
    }
}
