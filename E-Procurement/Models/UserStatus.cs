using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class UserStatus
    {
        public UserStatus()
        {
            UserDetail = new HashSet<UserDetail>();
        }

        public int StatusId { get; set; }
        public string StatusDescription { get; set; }

        public virtual ICollection<UserDetail> UserDetail { get; set; }
    }
}
