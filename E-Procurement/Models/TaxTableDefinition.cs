using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
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
