//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class RidePlannedObjectPrice
    {
        public int RidePlannedID { get; set; }
        public int RideObjectID { get; set; }
        public string RidePlannedObjectID { get; set; }
        public decimal CustomerPrice { get; set; }
        public decimal SupplierPrice { get; set; }
    
        public virtual RidePlanned RidePlanned { get; set; }
        public virtual t_RideObjects t_RideObjects { get; set; }
    }
}
