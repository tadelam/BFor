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
    
    public partial class t_DriverType
    {
        public t_DriverType()
        {
            this.Drivers = new HashSet<Driver>();
        }
    
        public int DriverTypeID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Driver> Drivers { get; set; }
    }
}
