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
    
    public partial class RidePlannedDriverLocation
    {
        public int RidePlannedID { get; set; }
        public int CompanyDriverID { get; set; }
        public int RidePlannedTimesID { get; set; }
        public int RidePlannedLocationsID { get; set; }
        public int RideDoneDriverLocationsID { get; set; }
    
        public virtual RideDoneDriverLocation RideDoneDriverLocation { get; set; }
        public virtual RidePlannedDriver RidePlannedDriver { get; set; }
        public virtual RidePlannedLocation RidePlannedLocation { get; set; }
        public virtual RidePlannedTime RidePlannedTime { get; set; }
    }
}
