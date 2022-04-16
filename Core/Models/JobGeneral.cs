using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class JobGeneral
    {
        public JobGeneral()
        {
            Employees = new HashSet<Employee>();
        }

        public int JobGeneralId { get; set; }
        public string LongDescription { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
