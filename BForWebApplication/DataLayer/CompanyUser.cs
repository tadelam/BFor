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
    
    public partial class CompanyUser
    {
        public int CompanyUserID { get; set; }
        public int CompanyID { get; set; }
        public int UserID { get; set; }
        public int EntityTypeRepSumID_UserTypeIDs_ { get; set; }
        public int RoleID { get; set; }
        public bool IsActive { get; set; }
        public bool IsShared { get; set; }
        public int NotifyTypeRepSum { get; set; }
        public Nullable<int> NotifyBy { get; set; }
        public Nullable<int> NotifyByTiming { get; set; }
        public Nullable<System.TimeSpan> NotifyByTimingAt { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual t_Roles t_Roles { get; set; }
        public virtual t_NotifyBy t_NotifyBy { get; set; }
        public virtual t_NotifyByTiming t_NotifyByTiming { get; set; }
        public virtual User User { get; set; }
    }
}
