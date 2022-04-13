using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class DisciplinaryCases
    {
        public int CaseId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CaseType { get; set; }
        public string CaseDescription { get; set; }
        public string Category { get; set; }
        public DateTime? DateOffenceCommitted { get; set; }
        public string CaseOutcome { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
