using System;
using System.Collections.Generic;

namespace Core.Models
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
