using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfPlanItem
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public string Unspsc { get; set; }
        public string Description { get; set; }
        public string RefNo { get; set; }
        public string ProjectCode { get; set; }
        public string Unitofmeasure { get; set; }
        public int? Quantity { get; set; }
        public string SourceOfFunds { get; set; }
        public string Prequalification { get; set; }
        public string ProcurementMethod { get; set; }
        public string Publication { get; set; }
        public string Award { get; set; }
        public DateTime? Start { get; set; }
        public string Comments { get; set; }
        public string Typeofentry { get; set; }
    }
}
