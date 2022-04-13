using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class CdfUsers
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] Logo { get; set; }
        public int? OrganizationId { get; set; }
        public int? RoleId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }
    }
}
