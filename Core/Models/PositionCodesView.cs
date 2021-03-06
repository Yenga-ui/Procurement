using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class PositionCodesView
    {
        public string JobTitleCode { get; set; } = null!;
        public string PositionCode { get; set; } = null!;
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public string? JobGrade { get; set; }
        public string? Department { get; set; }
        public string ReportsToPosition { get; set; } = null!;
        public string? EmployeeCode { get; set; }
        public string? EmployeeName { get; set; }
        public DateTime? StartDate { get; set; }
        public string? Status { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
