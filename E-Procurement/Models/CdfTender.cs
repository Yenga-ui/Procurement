using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class CdfTender
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DueDate { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string TenderSerial { get; set; }
        public string TenderProcedure { get; set; }
        public string TenderProcurementTechnique { get; set; }
        public DateTime? SubmissionDeadline { get; set; }
        public DateTime? ClarificationDeadline { get; set; }
        public DateTime? InvitationDate { get; set; }
        public DateTime? ContractNoticeDate { get; set; }
        public string EvaluationMechanism { get; set; }
        public string Department { get; set; }
        public string Units { get; set; }
        public string Status { get; set; }
        public int? BudgetExpenseId { get; set; }
        public int? BudgetId { get; set; }
        public decimal? Amount { get; set; }
        public int? Active { get; set; }
    }
}
