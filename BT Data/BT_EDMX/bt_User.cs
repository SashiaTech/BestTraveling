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
    
    public partial class bt_User
    {
        public System.Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Code { get; set; }
        public Nullable<System.Guid> RoleId { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
    
        public virtual bt_Roles bt_Roles { get; set; }
    }
}