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
    
    public partial class InvoiceLineItem
    {
        public int InvoiceID { get; set; }
        public int InvoiceSequence { get; set; }
        public string ProductDescription { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductExtension { get; set; }
        public decimal InvoiceTotal { get; set; }
        public string ProductNo { get; set; }
    }
}
