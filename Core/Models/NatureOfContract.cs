using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class NatureOfContract
    {
        public NatureOfContract()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string? ContractTypeCode { get; set; }
        public string? ContractTypeDecsription { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
