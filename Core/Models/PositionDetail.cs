using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class PositionDetail
    {
        public int PositionCodeId { get; set; }
        public string JobTitleCode { get; set; }
        public string PositionCode { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int DepartmentId { get; set; }
        public string ReportsToPositionCode { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? VacancyDate { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Department Department { get; set; }
        public virtual JobTitle JobTitleCodeNavigation { get; set; }
    }
}
