using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class Department
    {
        public Department()
        {
            Employee = new HashSet<Employee>();
            PositionDetails = new HashSet<PositionDetails>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentCode { get; set; }
        public string LongDescription { get; set; }
        public DateTime? LastChanged { get; set; }
        public string ChangedByUser { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<PositionDetails> PositionDetails { get; set; }
    }
}
