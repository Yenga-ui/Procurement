using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class NhimaConfiguration
    {
        public int Id { get; set; }
        public decimal Percentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
