using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class TaxTableDefinition
    {
        public int Id { get; set; }
        public string BandDescription { get; set; }
        public decimal? LowerLimit { get; set; }
        public decimal? UperLimit { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Percentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
    }
}
