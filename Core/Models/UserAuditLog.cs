using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class UserAuditLog
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
