﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CognitiveLocatorDAL.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CognitiveLocatorDBEntities : DbContext
    {
        public CognitiveLocatorDBEntities()
            : base("name=CognitiveLocatorDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hospital> Hospital { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
    }
}
