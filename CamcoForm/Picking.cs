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
    
    public partial class Picking
    {
        public int PickID { get; set; }
        public int InvoiceSO { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> QuantityPicked { get; set; }
        public Nullable<int> QuantityRemaining { get; set; }
        public Nullable<bool> Commit { get; set; }
        public string InvoicePO { get; set; }
        public string DateScheduled { get; set; }
    }
}
