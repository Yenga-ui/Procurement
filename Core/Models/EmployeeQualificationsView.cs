using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class EmployeeQualificationsView
    {
        public int FileId { get; set; }
        public string GuId { get; set; } = null!;
        public int? EmployeeId { get; set; }
        public string? DocumentType { get; set; }
        public string? QualificationType { get; set; }
        public string? FieldOfStudy { get; set; }
        public byte[] DocumentContent { get; set; } = null!;
        public string? DocumentName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmployeeCode { get; set; }
    }
}
