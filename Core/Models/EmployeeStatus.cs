using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class EmployeeStatus
    {
        public EmployeeStatus()
        {
            Employees = new HashSet<Employee>();
            Entities = new HashSet<Entity>();
        }

        public int StatusId { get; set; }
        public string? StatusCode { get; set; }
        public string? StatusDescription { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Entity> Entities { get; set; }
    }
}
