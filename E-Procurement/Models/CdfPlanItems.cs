using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class CdfPlanItems
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
        public decimal? Budget { get; set; }
        public string CreatedBy { get; set; }
        public int? ProcPlanId { get; set; }
    }
}
