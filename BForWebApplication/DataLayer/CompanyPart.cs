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
    
    public partial class CompanyPart
    {
        public int CompanyID { get; set; }
        public string PartID { get; set; }
        public decimal FixingCost { get; set; }
        public int FixingDays { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual t_Parts t_Parts { get; set; }
    }
}
