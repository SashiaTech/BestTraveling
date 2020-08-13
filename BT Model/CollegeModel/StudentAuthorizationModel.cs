using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Model.CollegeModel
{
    public class StudentAuthorizationModel
    {
        public Guid AuthorizationId { get; set; }
        public Guid StudentId { get; set; }
        public Guid CollegeId { get; set; }
        public string CollegeName { get; set; }

    }
}
