using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfProcPlan
    {
        public int Id { get; set; }
        public int? EntityId { get; set; }
        public string Year { get; set; }
        public int? Version { get; set; }
        public DateTime? Modified { get; set; }
        public string Comments { get; set; }
    }
}
