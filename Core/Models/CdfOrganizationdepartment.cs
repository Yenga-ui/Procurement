using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfOrganizationdepartment
    {
        public int Id { get; set; }
        public string? DepartmentName { get; set; }
        public int? DepartmentHeadJobId { get; set; }
    }
}
