﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CPRG214.Marina.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MarinaEntities : DbContext
    {
        public MarinaEntities()
            : base("name=MarinaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Dock> Docks { get; set; }
        public virtual DbSet<Lease> Leases { get; set; }
        public virtual DbSet<Slip> Slips { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
