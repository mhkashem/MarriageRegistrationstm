﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarriageRegistration.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MarriageRegistrationDBEntities : DbContext
    {
        public MarriageRegistrationDBEntities()
            : base("name=MarriageRegistrationDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Attorney> Attorneys { get; set; }
        public virtual DbSet<Kazi> Kazis { get; set; }
        public virtual DbSet<MarriageRegister> MarriageRegisters { get; set; }
        public virtual DbSet<NationalID> NationalIDs { get; set; }
        public virtual DbSet<Witness> Witnesses { get; set; }
    }
}
