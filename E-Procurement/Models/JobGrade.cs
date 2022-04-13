using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class JobGrade
    {
        public JobGrade()
        {
            Employee = new HashSet<Employee>();
            JobTitle = new HashSet<JobTitle>();
        }

        public int JobGradeId { get; set; }
        public string JobGradeCode { get; set; }
        public string JobGradeDescription { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<JobTitle> JobTitle { get; set; }
    }
}
