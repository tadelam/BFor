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
    
    public partial class Car
    {
        public Car()
        {
            this.CompanyCars = new HashSet<CompanyCar>();
        }
    
        public string PlateNo { get; set; }
        public int BrandModelID { get; set; }
        public Nullable<System.DateTime> LicenseDate { get; set; }
        public bool IsActive { get; set; }
    
        public virtual t_CarBrands t_CarBrands { get; set; }
        public virtual ICollection<CompanyCar> CompanyCars { get; set; }
    }
}
