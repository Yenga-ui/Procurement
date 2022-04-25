using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class UserMenu
    {
        public UserMenu()
        {
            UserMenuMappings = new HashSet<UserMenuMapping>();
        }

        public int Id { get; set; }
        public string? MenuDescription { get; set; }

        public virtual ICollection<UserMenuMapping> UserMenuMappings { get; set; }
    }
}
