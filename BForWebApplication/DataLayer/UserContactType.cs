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
    
    public partial class UserContactType
    {
        public UserContactType()
        {
            this.CompanyCustomerContacts = new HashSet<CompanyCustomerContact>();
        }
    
        public int UserID { get; set; }
        public int ContactTypeID { get; set; }
    
        public virtual ICollection<CompanyCustomerContact> CompanyCustomerContacts { get; set; }
        public virtual t_ContactType t_ContactType { get; set; }
        public virtual User User { get; set; }
    }
}
