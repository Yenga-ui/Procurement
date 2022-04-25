using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class PayslipDefinition
    {
        public int PayslipDefId { get; set; }
        public int EmployeeId { get; set; }
        public string? PayrollDefinitionCode { get; set; }
        public string? Description { get; set; }
        public decimal Value { get; set; }
        public string Type { get; set; } = null!;
        public string? OccurenceCode { get; set; }
        public DateTime PeriodStartDate { get; set; }
        public DateTime PeriodEndDate { get; set; }
        public int PayPeriod { get; set; }
        public DateTime DateModified { get; set; }
        public string? UserId { get; set; }
        public int PayrollDefinitionFlag { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual PayrollLinesFrequecyCode? OccurenceCodeNavigation { get; set; }
    }
}
