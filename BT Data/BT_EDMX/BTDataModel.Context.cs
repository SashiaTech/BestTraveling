﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BestTravelingEntities : DbContext
    {
        public BestTravelingEntities()
            : base("name=BestTravelingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bt_College> bt_College { get; set; }
        public virtual DbSet<bt_CollegeBranches> bt_CollegeBranches { get; set; }
        public virtual DbSet<bt_District> bt_District { get; set; }
        public virtual DbSet<bt_Roles> bt_Roles { get; set; }
        public virtual DbSet<bt_User> bt_User { get; set; }
        public virtual DbSet<bt_City> bt_City { get; set; }
        public virtual DbSet<bt_CollegeDirector> bt_CollegeDirector { get; set; }
        public virtual DbSet<bt_Gender> bt_Gender { get; set; }
        public virtual DbSet<bt_State> bt_State { get; set; }
    }
}
