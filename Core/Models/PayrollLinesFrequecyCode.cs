using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class PayrollLinesFrequecyCode
    {
        public PayrollLinesFrequecyCode()
        {
            PayslipDefinitions = new HashSet<PayslipDefinition>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<PayslipDefinition> PayslipDefinitions { get; set; }
    }
}
