using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class PayslipDetail
    {
        public int PayslipId { get; set; }
        public int? EmployeeId { get; set; }
        public int? DeductionDefId { get; set; }
        public decimal? DeductionAmount { get; set; }
        public int? EarningDefId { get; set; }
        public decimal? EarningAmount { get; set; }
        public DateTime? PayPeriod { get; set; }
        public int? LineFlag { get; set; }
        public int? UserId { get; set; }
    }
}
