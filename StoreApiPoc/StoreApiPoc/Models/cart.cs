//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreApiPoc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class cart
    {
        public int CartID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual product product { get; set; }
    }
}
