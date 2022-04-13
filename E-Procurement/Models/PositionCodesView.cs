using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class PositionCodesView
    {
        public string JobTitleCode { get; set; }
        public string PositionCode { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string JobGrade { get; set; }
        public string Department { get; set; }
        public string ReportsToPosition { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? StartDate { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
