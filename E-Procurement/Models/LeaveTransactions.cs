using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class LeaveTransactions
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? LeaveStartDate { get; set; }
        public DateTime? LeaveEndDate { get; set; }
        public int? LeaveTypeId { get; set; }
        public int? UnitsTaken { get; set; }
        public DateTime? DateApplied { get; set; }
        public string Status { get; set; }
        public DateTime? DateApproved { get; set; }
        public string ApprovedBy { get; set; }
    }
}
