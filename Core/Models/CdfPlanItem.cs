using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    [Table("CDF_PlanItems")]
    public partial class CdfPlanItem
    {
        public int Id { get; set; }
        public int PlanHeaderId { get; set; }
        public string Class { get; set; }
        public string Unspsc { get; set; }
        public string Description { get; set; }
        public string RefNo { get; set; }
        public string ProjectCode { get; set; }
        public string UnitOfMeasure { get; set; }
        public int? Quantity { get; set; }
        public string SourceOfFunds { get; set; }
        public string Prequalification { get; set; }
        public string ProcurementMethod { get; set; }
        public DateTime Publication { get; set; }
        public DateTime Award { get; set; }
        public DateTime? Start { get; set; }
        public string Comments { get; set; }
        public string TypeOfEntry { get; set; }
    }
}
