using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class JobGeneral
    {
        public JobGeneral()
        {
            Employee = new HashSet<Employee>();
        }

        public int JobGeneralId { get; set; }
        public string LongDescription { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
