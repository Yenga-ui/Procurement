using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class EmployeeDetail
    {
        public int EmployeeId { get; set; }
        public int EntityCode { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MaidenName { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string IdType { get; set; }
        public string Idnumber { get; set; }
        public string Title { get; set; }
        public string DateEngaged { get; set; }
        public string PensionStartDate { get; set; }
        public string LeaveStartDate { get; set; }
        public string TerminationDate { get; set; }
        public string TerminationReason { get; set; }
        public string JobTitle { get; set; }
        public string JobGrade { get; set; }
        public string JobGeneral { get; set; }
        public int? StatusId { get; set; }
        public string EmployeeStatus { get; set; }
        public string NatureOfContract { get; set; }
        public string Department { get; set; }
        public decimal? BasicPay { get; set; }
        public string CellPhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PhysicalAddress { get; set; }
        public int? SocialSecurityNumber { get; set; }
        public string MaritalStatus { get; set; }
        public string PositionCode { get; set; }
    }
}
