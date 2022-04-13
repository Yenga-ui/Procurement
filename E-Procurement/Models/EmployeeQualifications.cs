using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class EmployeeQualifications
    {
        public int FileId { get; set; }
        public string GuId { get; set; }
        public int? EmployeeId { get; set; }
        public string DocumentType { get; set; }
        public string QualificationType { get; set; }
        public string FieldOfStudy { get; set; }
        public byte[] DocumentContent { get; set; }
        public string DocumentName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
