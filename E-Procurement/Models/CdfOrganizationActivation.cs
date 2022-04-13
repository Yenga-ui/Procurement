using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class CdfOrganizationActivation
    {
        public int Id { get; set; }
        public int? OrganizationId { get; set; }
        public int? ActivationCode { get; set; }
        public int? Activation { get; set; }
    }
}
