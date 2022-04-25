using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class UserRole
    {
        public UserRole()
        {
            UserDetails = new HashSet<UserDetail>();
            UserMenuMappings = new HashSet<UserMenuMapping>();
        }

        public int UserRoleId { get; set; }
        public string? RoleDescription { get; set; }

        public virtual ICollection<UserDetail> UserDetails { get; set; }
        public virtual ICollection<UserMenuMapping> UserMenuMappings { get; set; }
    }
}
