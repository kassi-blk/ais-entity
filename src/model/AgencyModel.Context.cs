﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ais.src.model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AgencyEntities : DbContext
    {
        public AgencyEntities()
            : base("name=AgencyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ContractorsMedia> ContractorsMedia { get; set; }
        public virtual DbSet<ContractorsProduction> ContractorsProduction { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Leads> Leads { get; set; }
        public virtual DbSet<OrdReqs> OrdReqs { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
    }
}