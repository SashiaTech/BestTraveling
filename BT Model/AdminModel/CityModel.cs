﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Model.AdminModel
{
    public class CityModel
    {
        public Guid CityId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid? DistrictId{ get; set; }
        public string DistrictName { get; set; }
        public Guid? CountryId { get; set; }
        public string Country { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? StateId { get; set; }
        public string StateName { get; set; }
        public bool IsActive { get; set; }

    }
}
