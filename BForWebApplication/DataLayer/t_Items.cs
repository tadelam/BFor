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
    
    public partial class t_Items
    {
        public t_Items()
        {
            this.t_Roles = new HashSet<t_Roles>();
        }
    
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual ICollection<t_Roles> t_Roles { get; set; }
    }
}
