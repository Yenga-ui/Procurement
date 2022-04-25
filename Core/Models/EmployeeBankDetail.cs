using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class EmployeeBankDetail
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int BankId { get; set; }
        public int BranchId { get; set; }
        public string? AccountName { get; set; }
        public string? AccountNumber { get; set; }
        public int StatusId { get; set; }
        public int IsDefaultBank { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
