using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class SupplierRegistation
    {
        public int Id { get; set; }
        public string SupplierRegistrationCode { get; set; }
        public string CompanyRegistrationNumber { get; set; }
        public string Tpin { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationType { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string CountryOfRegistration { get; set; }
        public string Shareholders { get; set; }
        public string CompanyStatusZra { get; set; }
        public string CompanyStatusNapsa { get; set; }
        public string ConfirmationCode { get; set; }
        public string Email { get; set; }
        public int? Paid { get; set; }
    }
}
