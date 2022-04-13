using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class CdfOrganizationprofile
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string LegalName { get; set; }
        public string CompanyWebsite { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyAddress { get; set; }
        public int OrganizationId { get; set; }
    }
}
