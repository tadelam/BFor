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
    
    public partial class RidePlannedCarLocation
    {
        public int RidePlannedID { get; set; }
        public int CompanyCarPlatID { get; set; }
        public int RidePlannedTimesID { get; set; }
        public int RidePlannedLocationsID { get; set; }
        public int RideDoneCarLocationID { get; set; }
    
        public virtual RideDoneCarLocation RideDoneCarLocation { get; set; }
        public virtual RidePlannedCar RidePlannedCar { get; set; }
        public virtual RidePlannedLocation RidePlannedLocation { get; set; }
        public virtual RidePlannedTime RidePlannedTime { get; set; }
    }
}
