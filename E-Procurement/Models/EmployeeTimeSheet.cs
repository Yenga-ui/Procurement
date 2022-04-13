using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class EmployeeTimeSheet
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? HoursWorked { get; set; }
        public DateTime? DateWorked { get; set; }
        public DateTime? PeriodStartDate { get; set; }
        public DateTime? PeriodEndDate { get; set; }
        public string Status { get; set; }
        public DateTime? DateCreated { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? DateApproved { get; set; }
    }
}
