//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class PurchaseOrder
    {
        public int PurchaseID { get; set; }
        public int VendorID { get; set; }
        public string VendorName { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<decimal> PurchaseTotal { get; set; }
        public string PurchaseSO { get; set; }
        public string PurchasePO { get; set; }
    }
}
