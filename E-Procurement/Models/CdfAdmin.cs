using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class CdfAdmin
    {
        public int Id { get; set; }
        public int? OrganizationId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? Active { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
    }
}
