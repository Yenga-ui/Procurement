using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class PayslipDetailArchive
    {
        public int PayslipArchiveId { get; set; }
        public int? EmpoyeeId { get; set; }
        public int? DeductionDefId { get; set; }
        public decimal? DeductionAmount { get; set; }
        public int? EarningDefId { get; set; }
        public decimal? EarningAmount { get; set; }
        public DateTime? PayPeriod { get; set; }
        public DateTime? ExportDate { get; set; }
        public int? ExportedByUserId { get; set; }
    }
}
