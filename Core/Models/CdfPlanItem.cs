using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfPlanItem
    {
        public int Id { get; set; }
        public int? PlanHeaderId { get; set; }
        public string Class { get; set; } = null!;
        public string? Unspsc { get; set; }
        public string Description { get; set; } = null!;
        public string RefNo { get; set; } = null!;
        public string? ProjectCode { get; set; }
        public string? UnitOfMeasure { get; set; }
        public string? Quantity { get; set; }
        public string? SourceOfFunds { get; set; }
        public string? Prequalification { get; set; }
        public string? ProcurementMethod { get; set; }
        public DateTime Publication { get; set; }
        public DateTime Award { get; set; }
        public DateTime? Start { get; set; }
        public string? Comments { get; set; }
        public string? TypeOfEntry { get; set; }
    }
}
