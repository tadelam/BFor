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
    
    public partial class CompanyPassenger
    {
        public CompanyPassenger()
        {
            this.RideDonePassengerLocations = new HashSet<RideDonePassengerLocation>();
            this.RidePlannedPassengerLocations = new HashSet<RidePlannedPassengerLocation>();
        }
    
        public int CompanyPassengerID { get; set; }
        public int CompanyID { get; set; }
        public string PassengerID { get; set; }
        public int PassengerGroupID { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual CompanyPassengerGroup CompanyPassengerGroup { get; set; }
        public virtual ICollection<RideDonePassengerLocation> RideDonePassengerLocations { get; set; }
        public virtual ICollection<RidePlannedPassengerLocation> RidePlannedPassengerLocations { get; set; }
        public virtual Passenger Passenger { get; set; }
        public virtual CompanyPassenger CompanyPassengers1 { get; set; }
        public virtual CompanyPassenger CompanyPassenger1 { get; set; }
    }
}