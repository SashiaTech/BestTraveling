//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BestTraveling.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class bt_CollegeDirector
    {
        public System.Guid DirectorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.Guid> GenderId { get; set; }
        public string Code { get; set; }
        public Nullable<System.Guid> CollegeId { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public Nullable<int> Age { get; set; }
        public System.Guid StateId { get; set; }
        public System.Guid DistrictId { get; set; }
        public System.Guid CityId { get; set; }
        public Nullable<System.DateTime> CratedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
    
        public virtual bt_City bt_City { get; set; }
        public virtual bt_College bt_College { get; set; }
        public virtual bt_District bt_District { get; set; }
        public virtual bt_Gender bt_Gender { get; set; }
        public virtual bt_State bt_State { get; set; }
    }
}