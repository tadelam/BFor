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
    
    public partial class RideDoneCar
    {
        public RideDoneCar()
        {
            this.RideDoneCarLocations = new HashSet<RideDoneCarLocation>();
        }
    
        public int RideDoneID { get; set; }
        public int CompanyCarPlatID { get; set; }
        public double Percentage { get; set; }
    
        public virtual CompanyCar CompanyCar { get; set; }
        public virtual RideDone RideDone { get; set; }
        public virtual ICollection<RideDoneCarLocation> RideDoneCarLocations { get; set; }
    }
}
