//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicWeb.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice_Service
    {
        public int id { get; set; }
        public Nullable<int> invoice_id { get; set; }
        public Nullable<int> service_id { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<decimal> unit_price { get; set; }
        public Nullable<decimal> discount { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Service Service { get; set; }
    }
}
