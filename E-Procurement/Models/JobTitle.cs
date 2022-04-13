using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class JobTitle
    {
        public JobTitle()
        {
            Employee = new HashSet<Employee>();
            PositionDetails = new HashSet<PositionDetails>();
        }

        public int JobTitleId { get; set; }
        public string Jobcode { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int? JobGradeId { get; set; }
        public string Status { get; set; }
        public DateTime? LastChanged { get; set; }
        public string ChangedByUser { get; set; }

        public virtual JobGrade JobGrade { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<PositionDetails> PositionDetails { get; set; }
    }
}
