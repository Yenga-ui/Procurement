using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class CdfOrganization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstAdminIdentityType { get; set; }
        public string FirstAdminId { get; set; }
        public string FirstAdminPhone { get; set; }
        public string FirstAdminEmail { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Activated { get; set; }
        public byte[] Logo { get; set; }
    }
}
