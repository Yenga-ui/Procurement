using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class LeaveTransaction
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
