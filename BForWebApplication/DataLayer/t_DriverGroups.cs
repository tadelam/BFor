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
    
    public partial class t_DriverGroups
    {
        public t_DriverGroups()
        {
            this.CompanyDrivers = new HashSet<CompanyDriver>();
        }
    
        public int DriverGroupID { get; set; }
        public string GroupCode { get; set; }
        public string GroupDesc { get; set; }
    
        public virtual ICollection<CompanyDriver> CompanyDrivers { get; set; }
    }
}
