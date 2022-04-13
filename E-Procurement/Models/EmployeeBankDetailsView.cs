using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
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
