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
    
    public partial class t_PassengerGroups
    {
        public t_PassengerGroups()
        {
            this.CompanyPassengerGroups = new HashSet<CompanyPassengerGroup>();
        }
    
        public int PassengerGroupID { get; set; }
        public string GroupCode { get; set; }
        public string GroupDesc { get; set; }
    
        public virtual ICollection<CompanyPassengerGroup> CompanyPassengerGroups { get; set; }
    }
}
