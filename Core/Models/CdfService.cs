using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfService
    {
        public int Id { get; set; }
        public string? Service { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
