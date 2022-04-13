using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class UserAuditLogs
    {
        public int AuditId { get; set; }
        public string Guid { get; set; }
        public string UserName { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? ActionDate { get; set; }
        public string ActionType { get; set; }
        public string Action { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
