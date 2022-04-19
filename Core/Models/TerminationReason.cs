using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class TerminationReason
    {
        public TerminationReason()
        {
            Employees = new HashSet<Employee>();
        }

        public int TerminationReasonId { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime? DateCreated { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
