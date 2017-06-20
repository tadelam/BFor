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
    
    public partial class CompanyCar
    {
        public CompanyCar()
        {
            this.RideDoneCars = new HashSet<RideDoneCar>();
            this.CompanyDrivers = new HashSet<CompanyDriver>();
            this.RidePlannedCars = new HashSet<RidePlannedCar>();
        }
    
        public int CompanyCarPlatID { get; set; }
        public string CarPlatNo { get; set; }
        public int CompanyID { get; set; }
        public Nullable<System.DateTime> InsuranceDate { get; set; }
        public int CarGroupID { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Car Car { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<RideDoneCar> RideDoneCars { get; set; }
        public virtual ICollection<CompanyDriver> CompanyDrivers { get; set; }
        public virtual ICollection<RidePlannedCar> RidePlannedCars { get; set; }
        public virtual t_CarGroups t_CarGroups { get; set; }
    }
}
