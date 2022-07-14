﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CamcoForm
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CamcoEntities : DbContext
    {
        public CamcoEntities()
            : base("name=CamcoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<InvoiceLineItem> InvoiceLineItems { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<Kit> Kits { get; set; }
        public virtual DbSet<Picking> Pickings { get; set; }
        public virtual DbSet<Shipping> Shippings { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<Receiving> Receivings { get; set; }
        public virtual DbSet<PurchaseOrderLineItem> PurchaseOrderLineItems { get; set; }
        public virtual DbSet<Received> Receiveds { get; set; }
        public virtual DbSet<ShipLineItem> ShipLineItems { get; set; }
        public virtual DbSet<ShipInvoice> ShipInvoices { get; set; }
    }
}
