using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfDepartment
    {
        public int Id { get; set; }
        public string? Department { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
