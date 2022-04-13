using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class LeaveTypes
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string LeaveTypeDescription { get; set; }
        public int Entitlement { get; set; }
        public string ApplicableGender { get; set; }
        public string Cycle { get; set; }
        public string BalanceBroughtForwardOption { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }
    }
}
