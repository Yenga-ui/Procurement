using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
