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
    
    public partial class CompanyCustomer
    {
        public CompanyCustomer()
        {
            this.CompanyCustomerContacts = new HashSet<CompanyCustomerContact>();
        }
    
        public int CompanyCustomerID { get; set; }
        public int CompanyAID { get; set; }
        public int CompanyBID { get; set; }
        public int CustometrGroupID { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Company Company1 { get; set; }
        public virtual ICollection<CompanyCustomerContact> CompanyCustomerContacts { get; set; }
        public virtual CompanyCustomerGroup CompanyCustomerGroup { get; set; }
    }
}
