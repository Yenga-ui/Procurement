using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class Employee
    {
        public Employee()
        {
            DisciplinaryCases = new HashSet<DisciplinaryCase>();
            EmployeeBankDetails = new HashSet<EmployeeBankDetail>();
            EmployeeQualifications = new HashSet<EmployeeQualification>();
            EmployeeRemunerations = new HashSet<EmployeeRemuneration>();
            LeaveDetails = new HashSet<LeaveDetail>();
            PayslipDefinitions = new HashSet<PayslipDefinition>();
        }

        public int EmployeeId { get; set; }
        public int EntityId { get; set; }
        public string EmployeeCode { get; set; } = null!;
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

        public virtual Department? Department { get; set; }
        public virtual EmployeeStatus? EmployeeStatus { get; set; }
        public virtual Entity Entity { get; set; } = null!;
        public virtual JobGeneral? JobGeneral { get; set; }
        public virtual JobGrade? JobGrade { get; set; }
        public virtual JobTitle? JobTitle { get; set; }
        public virtual NatureOfContract? NatureOfContract { get; set; }
        public virtual TerminationReason? TerminationReason { get; set; }
        public virtual ICollection<DisciplinaryCase> DisciplinaryCases { get; set; }
        public virtual ICollection<EmployeeBankDetail> EmployeeBankDetails { get; set; }
        public virtual ICollection<EmployeeQualification> EmployeeQualifications { get; set; }
        public virtual ICollection<EmployeeRemuneration> EmployeeRemunerations { get; set; }
        public virtual ICollection<LeaveDetail> LeaveDetails { get; set; }
        public virtual ICollection<PayslipDefinition> PayslipDefinitions { get; set; }
    }
}
