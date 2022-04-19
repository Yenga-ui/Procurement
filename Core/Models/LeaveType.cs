using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class LeaveType
    {
        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string LeaveTypeDescription { get; set; } = null!;
        public int Entitlement { get; set; }
        public string ApplicableGender { get; set; } = null!;
        public string? Cycle { get; set; }
        public string? BalanceBroughtForwardOption { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? CreatedBy { get; set; }
    }
}
