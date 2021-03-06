//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Consumer
    {
        public int ConsumerId { get; set; }
        public string ConsumerName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public string Designation { get; set; }
        public string OfficeAddress { get; set; }
        public string Country { get; set; }
        public int SubscriptionId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public int RoleId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public int IndustryId { get; set; }
    
        public virtual IndustryMaster IndustryMaster { get; set; }
        public virtual SubscriptionMaster SubscriptionMaster { get; set; }
        public virtual RoleMaster RoleMaster { get; set; }
    }
}
