using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class NatureOfContract
    {
        public NatureOfContract()
        {
            Employee = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string ContractTypeCode { get; set; }
        public string ContractTypeDecsription { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
