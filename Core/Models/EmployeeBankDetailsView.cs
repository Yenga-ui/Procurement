using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class EmployeeBankDetailsView
    {
        public string EmployeeCode { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string StatusCode { get; set; }
        public int IsDefaultBank { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
