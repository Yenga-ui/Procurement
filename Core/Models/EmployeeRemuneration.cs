using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class EmployeeRemuneration
    {
        public int RemunerationId { get; set; }
        public int EmployeeId { get; set; }
        public decimal? RemunerationAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Reason { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string UserId { get; set; } = null!;

        public virtual Employee Employee { get; set; } = null!;
    }
}
