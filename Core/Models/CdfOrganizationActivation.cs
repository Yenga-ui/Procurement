using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfOrganizationActivation
    {
        public int Id { get; set; }
        public int? OrganizationId { get; set; }
        public int? ActivationCode { get; set; }
        public int? Activation { get; set; }
    }
}
