﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wcfmayoreoc
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mayoreocEntities : DbContext
    {
        public mayoreocEntities()
            : base("name=mayoreocEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<carritos> carritos { get; set; }
        public virtual DbSet<catalogos> catalogos { get; set; }
        public virtual DbSet<categorias> categorias { get; set; }
        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<cuentasbancarias> cuentasbancarias { get; set; }
        public virtual DbSet<envios> envios { get; set; }
        public virtual DbSet<metodospago> metodospago { get; set; }
        public virtual DbSet<ordencompra> ordencompra { get; set; }
        public virtual DbSet<pagos> pagos { get; set; }
        public virtual DbSet<productos> productos { get; set; }
        public virtual DbSet<subcategorias> subcategorias { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
        public virtual DbSet<cortecaja> cortecaja { get; set; }
    }
}