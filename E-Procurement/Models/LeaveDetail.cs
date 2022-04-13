using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class LeaveDetail
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime? LeaveAccrualStartDate { get; set; }
        public decimal? LeaveBalance { get; set; }
        public decimal? MonetaryEquivalent { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
