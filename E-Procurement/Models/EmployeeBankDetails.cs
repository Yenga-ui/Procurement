using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class EmployeeBankDetails
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int BankId { get; set; }
        public int BranchId { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public int StatusId { get; set; }
        public int IsDefaultBank { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
