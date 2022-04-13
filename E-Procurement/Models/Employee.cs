using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class Employee
    {
        public Employee()
        {
            DisciplinaryCases = new HashSet<DisciplinaryCases>();
            EmployeeBankDetails = new HashSet<EmployeeBankDetails>();
            EmployeeQualifications = new HashSet<EmployeeQualifications>();
            EmployeeRemuneration = new HashSet<EmployeeRemuneration>();
            LeaveDetail = new HashSet<LeaveDetail>();
            PayslipDefinition = new HashSet<PayslipDefinition>();
        }

        public int EmployeeId { get; set; }
        public int EntityId { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime? DateEngaged { get; set; }
        public DateTime? LeaveStartDate { get; set; }
        public DateTime? PensionStartDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public int? TerminationReasonId { get; set; }
        public int? JobTitleId { get; set; }
        public int? JobGradeId { get; set; }
        public int? JobGeneralId { get; set; }
        public int? EmployeeStatusId { get; set; }
        public int? ReportToEmployeeId { get; set; }
        public int? NatureOfContractId { get; set; }
        public int? DepartmentId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Department Department { get; set; }
        public virtual EmployeeStatus EmployeeStatus { get; set; }
        public virtual Entity Entity { get; set; }
        public virtual JobGeneral JobGeneral { get; set; }
        public virtual JobGrade JobGrade { get; set; }
        public virtual JobTitle JobTitle { get; set; }
        public virtual NatureOfContract NatureOfContract { get; set; }
        public virtual TerminationReason TerminationReason { get; set; }
        public virtual ICollection<DisciplinaryCases> DisciplinaryCases { get; set; }
        public virtual ICollection<EmployeeBankDetails> EmployeeBankDetails { get; set; }
        public virtual ICollection<EmployeeQualifications> EmployeeQualifications { get; set; }
        public virtual ICollection<EmployeeRemuneration> EmployeeRemuneration { get; set; }
        public virtual ICollection<LeaveDetail> LeaveDetail { get; set; }
        public virtual ICollection<PayslipDefinition> PayslipDefinition { get; set; }
    }
}
