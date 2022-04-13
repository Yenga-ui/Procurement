using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class UserMenu
    {
        public UserMenu()
        {
            UserMenuMapping = new HashSet<UserMenuMapping>();
        }

        public int Id { get; set; }
        public string MenuDescription { get; set; }

        public virtual ICollection<UserMenuMapping> UserMenuMapping { get; set; }
    }
}
