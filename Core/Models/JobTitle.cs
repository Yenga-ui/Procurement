using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class JobTitle
    {
        public JobTitle()
        {
            Employees = new HashSet<Employee>();
            PositionDetails = new HashSet<PositionDetail>();
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
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<PositionDetail> PositionDetails { get; set; }
    }
}
