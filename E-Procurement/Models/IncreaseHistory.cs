using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class IncreaseHistory
    {
        public int IncreaseHistoryId { get; set; }
        public int EmployeeId { get; set; }
        public int? IncreaseReasonTypeId { get; set; }
        public string IncreaseAppliedOn { get; set; }
        public decimal? IncreaseAmount { get; set; }
        public decimal? IncreasePercentage { get; set; }
        public decimal? PreviousAnnualSalary { get; set; }
        public decimal? NewAnnualSalary { get; set; }
        public decimal? PreviousMonthlySalary { get; set; }
        public decimal? NewMonthlySalary { get; set; }
        public decimal? PreviousRatePerHour { get; set; }
        public decimal? NewRatePerHour { get; set; }
        public decimal? PreviousRatePerDay { get; set; }
        public decimal? NewRatePerDay { get; set; }
        public int? JobGradeId { get; set; }
        public int? JobTitleId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? IncreaseProcessedDate { get; set; }
        public int? ProcessedByUserId { get; set; }
        public DateTime? LastChanged { get; set; }
    }
}
