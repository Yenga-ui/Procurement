using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
            PositionDetails = new HashSet<PositionDetail>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentCode { get; set; } = null!;
        public string? LongDescription { get; set; }
        public DateTime? LastChanged { get; set; }
        public string? ChangedByUser { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<PositionDetail> PositionDetails { get; set; }
    }
}
