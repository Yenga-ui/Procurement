using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class CdfOrganizationjobs
    {
        public int Id { get; set; }
        public int? OrganizationLevel { get; set; }
        public string OrganizationTitle { get; set; }
        public int? Strength { get; set; }
        public int? OrganizationGrade { get; set; }
        public int? OrganizationId { get; set; }
    }
}
