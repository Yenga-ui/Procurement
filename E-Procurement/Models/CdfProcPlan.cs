using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
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
