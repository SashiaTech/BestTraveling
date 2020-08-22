using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Model.AdminModel
{
    public class StateModel
    {
        public Guid StateId { get; set; }

        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }
        public Guid? CountryId { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public string CountryName { get; set; }
    }
}
