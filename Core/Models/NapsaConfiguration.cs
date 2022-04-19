using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class NapsaConfiguration
    {
        public int Id { get; set; }
        public decimal Percentage { get; set; }
        public decimal MaximumCeiling { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
