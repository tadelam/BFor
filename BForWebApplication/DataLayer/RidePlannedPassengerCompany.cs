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
    
    public partial class RidePlannedPassengerCompany
    {
        public int RidePlannedID { get; set; }
        public int CompanyID { get; set; }
        public double Percentage { get; set; }
        public int RideDonePassengerCompanyID { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual RideDonePassengerCompany RideDonePassengerCompany { get; set; }
        public virtual RidePlanned RidePlanned { get; set; }
    }
}