using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class JobGrade
    {
        public JobGrade()
        {
            Employees = new HashSet<Employee>();
            JobTitles = new HashSet<JobTitle>();
        }

        public int JobGradeId { get; set; }
        public string JobGradeCode { get; set; }
        public string JobGradeDescription { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<JobTitle> JobTitles { get; set; }
    }
}
