//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BT_Data.BT_EDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class bt_Fares
    {
        public System.Guid FareId { get; set; }
        public string Code { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.Guid> CountryId { get; set; }
        public Nullable<System.Guid> StateId { get; set; }
        public Nullable<System.Guid> CityId { get; set; }
        public string ZipCode { get; set; }
        public string XLat { get; set; }
        public string YLat { get; set; }
        public Nullable<int> NumberOfStops { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.Guid> DistrictId { get; set; }
    
        public virtual bt_City bt_City { get; set; }
        public virtual bt_Country bt_Country { get; set; }
        public virtual bt_State bt_State { get; set; }
    }
}
