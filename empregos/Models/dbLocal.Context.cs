﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace empregos.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class empregobdlocalEntities2 : DbContext
    {
        public empregobdlocalEntities2()
            : base("name=empregobdlocalEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<anuncio> anuncio { get; set; }
        public virtual DbSet<categoria> categoria { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}
