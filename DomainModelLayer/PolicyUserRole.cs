//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainModelLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class PolicyUserRole
    {
        public System.Guid ID { get; set; }
        public System.Guid RoleID { get; set; }
        public System.Guid UserID { get; set; }
        public System.Guid PolicyID { get; set; }
    
        public virtual Policies Policies { get; set; }
        public virtual Roles Roles { get; set; }
        public virtual Users Users { get; set; }
    }
}
