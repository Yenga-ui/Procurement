using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class PayrollRunDetailsView
    {
        public string EmployeeCode { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string IdNumber { get; set; } = null!;
        public string? Gender { get; set; }
        public string? JobGeneral { get; set; }
        public string? JobTitle { get; set; }
        public string? JobGrade { get; set; }
        public string? DateEngaged { get; set; }
        public decimal? BasicPay { get; set; }
        public string? AccountName { get; set; }
        public string? AccountNumber { get; set; }
        public string? BankName { get; set; }
        public string? BranchName { get; set; }
        public string? BranchCode { get; set; }
    }
}
