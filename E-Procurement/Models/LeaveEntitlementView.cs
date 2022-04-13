using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class LeaveEntitlementView
    {
        public string EmployeeCode { get; set; }
        public string LeaveAccrualStartDate { get; set; }
        public string LeaveTypeDescription { get; set; }
        public int? Entitlement { get; set; }
        public decimal? LeaveBalance { get; set; }
        public decimal? MonetaryValue { get; set; }
    }
}
