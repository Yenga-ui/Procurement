using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class UserMenuMapping
    {
        public int UserMenuMappingId { get; set; }
        public int? UserRoleId { get; set; }
        public int? UserMenuId { get; set; }

        public virtual UserMenu UserMenu { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
