using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class UserRoles
    {
        public UserRoles()
        {
            UserDetail = new HashSet<UserDetail>();
            UserMenuMapping = new HashSet<UserMenuMapping>();
        }

        public int UserRoleId { get; set; }
        public string RoleDescription { get; set; }

        public virtual ICollection<UserDetail> UserDetail { get; set; }
        public virtual ICollection<UserMenuMapping> UserMenuMapping { get; set; }
    }
}
