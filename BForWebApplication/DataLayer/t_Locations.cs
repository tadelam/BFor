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
    
    public partial class t_Locations
    {
        public t_Locations()
        {
            this.RideDoneLocations = new HashSet<RideDoneLocation>();
            this.RideDoneLocations1 = new HashSet<RideDoneLocation>();
            this.RidePlanneds = new HashSet<RidePlanned>();
            this.RidePlanneds1 = new HashSet<RidePlanned>();
            this.RidePlannedLocations = new HashSet<RidePlannedLocation>();
            this.RidePlannedLocations1 = new HashSet<RidePlannedLocation>();
        }
    
        public int LocationID { get; set; }
        public decimal LocationGpsNDecimalCrdnt { get; set; }
        public decimal LocationGpsEDecimalCrdnt { get; set; }
        public string LocationDescription { get; set; }
    
        public virtual ICollection<RideDoneLocation> RideDoneLocations { get; set; }
        public virtual ICollection<RideDoneLocation> RideDoneLocations1 { get; set; }
        public virtual ICollection<RidePlanned> RidePlanneds { get; set; }
        public virtual ICollection<RidePlanned> RidePlanneds1 { get; set; }
        public virtual ICollection<RidePlannedLocation> RidePlannedLocations { get; set; }
        public virtual ICollection<RidePlannedLocation> RidePlannedLocations1 { get; set; }
    }
}
