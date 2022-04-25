using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfTenderProcedure
    {
        public int Id { get; set; }
        public string? TenderProcedure { get; set; }
        public int? NumberofBidders { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
