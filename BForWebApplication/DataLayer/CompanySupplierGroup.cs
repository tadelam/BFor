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
    
    public partial class CompanySupplierGroup
    {
        public CompanySupplierGroup()
        {
            this.CompanySuppliers = new HashSet<CompanySupplier>();
        }
    
        public int CompanyID { get; set; }
        public int SupplierGroupID { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual ICollection<CompanySupplier> CompanySuppliers { get; set; }
        public virtual t_SupplierGroups t_SupplierGroups { get; set; }
    }
}