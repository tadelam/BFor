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
    
    public partial class RideDoneCarLocation
    {
        public RideDoneCarLocation()
        {
            this.RidePlannedCarLocations = new HashSet<RidePlannedCarLocation>();
        }
    
        public int RideDoneCarLocationID { get; set; }
        public int RideDoneID { get; set; }
        public int CompanyCarPlatID { get; set; }
        public int RideDoneLocationsID { get; set; }
    
        public virtual ICollection<RidePlannedCarLocation> RidePlannedCarLocations { get; set; }
        public virtual RideDoneCar RideDoneCar { get; set; }
        public virtual RideDoneLocation RideDoneLocation { get; set; }
    }
}
