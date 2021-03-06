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
    
    public partial class RidePlannedTime
    {
        public RidePlannedTime()
        {
            this.RidePlannedCarLocations = new HashSet<RidePlannedCarLocation>();
            this.RidePlannedDriverLocations = new HashSet<RidePlannedDriverLocation>();
            this.RidePlannedLocations = new HashSet<RidePlannedLocation>();
            this.RidePlannedPassengerLocations = new HashSet<RidePlannedPassengerLocation>();
        }
    
        public int RidePlannedID { get; set; }
        public int RidePlannedTimesID { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan FromTime { get; set; }
        public System.TimeSpan ToTime { get; set; }
        public double CostFactor { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> RideDoneID { get; set; }
    
        public virtual RideDone RideDone { get; set; }
        public virtual RidePlanned RidePlanned { get; set; }
        public virtual ICollection<RidePlannedCarLocation> RidePlannedCarLocations { get; set; }
        public virtual ICollection<RidePlannedDriverLocation> RidePlannedDriverLocations { get; set; }
        public virtual ICollection<RidePlannedLocation> RidePlannedLocations { get; set; }
        public virtual ICollection<RidePlannedPassengerLocation> RidePlannedPassengerLocations { get; set; }
    }
}
