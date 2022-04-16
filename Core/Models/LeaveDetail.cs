using System;
using System.Collections.Generic;

namespace Core.Models
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
