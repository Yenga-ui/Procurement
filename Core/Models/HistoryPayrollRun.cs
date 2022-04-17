using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class HistoryPayrollRun
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? PayPeriod { get; set; }
        public string CreatedBy { get; set; }
    }
}
