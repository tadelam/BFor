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
    
    public partial class CompanyCustomerGroup
    {
        public CompanyCustomerGroup()
        {
            this.CompanyCustomers = new HashSet<CompanyCustomer>();
        }
    
        public int CompanyID { get; set; }
        public int CustomerGroupID { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual ICollection<CompanyCustomer> CompanyCustomers { get; set; }
        public virtual t_CustomerGroups t_CustomerGroups { get; set; }
    }
}