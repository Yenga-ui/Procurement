using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfOrganizationjob
    {
        public int Id { get; set; }
        public int? OrganizationLevel { get; set; }
        public string? OrganizationTitle { get; set; }
        public int? Strength { get; set; }
        public int? OrganizationGrade { get; set; }
        public int? OrganizationId { get; set; }
    }
}
