﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rogernoob
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class practicam6Entities : DbContext
    {
        public practicam6Entities()
            : base("name=practicam6Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<clients> clients { get; set; }
        public DbSet<factura> factura { get; set; }
        public DbSet<factura_detall> factura_detall { get; set; }
        public DbSet<productes> productes { get; set; }
    }
}
