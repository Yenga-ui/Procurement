using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class EmployeeHistory
    {
        public int EmployeeHistoryId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; } = null!;
        public int EmployeeStatusId { get; set; }
        public DateTime? TerminationDate { get; set; }
        public int? TerminationReasonId { get; set; }
        public DateTime? DateEngaged { get; set; }
        public int? JobGradeId { get; set; }
        public int? JobTitleId { get; set; }
        public string? PositionCode { get; set; }
        public int? JobGeneralId { get; set; }
        public int? NatureOfContractId { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
    }
}
