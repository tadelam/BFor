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
    
    public partial class RidePlannedPassengerLocation
    {
        public int RidePlannedID { get; set; }
        public int RidePlannedTimesID { get; set; }
        public int CompanyPassengerID { get; set; }
        public int RidePlannedLocationsID { get; set; }
        public int RideDonePassengerLocationsID { get; set; }
    
        public virtual CompanyPassenger CompanyPassenger { get; set; }
        public virtual RideDonePassengerLocation RideDonePassengerLocation { get; set; }
        public virtual RidePlanned RidePlanned { get; set; }
        public virtual RidePlannedLocation RidePlannedLocation { get; set; }
        public virtual RidePlannedTime RidePlannedTime { get; set; }
    }
}
