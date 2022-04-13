using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class UserMenuMapping
    {
        public int UserMenuMappingId { get; set; }
        public int? UserRoleId { get; set; }
        public int? UserMenuId { get; set; }

        public virtual UserMenu UserMenu { get; set; }
        public virtual UserRoles UserRole { get; set; }
    }
}
