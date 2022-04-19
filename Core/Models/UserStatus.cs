using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class UserStatus
    {
        public UserStatus()
        {
            UserDetails = new HashSet<UserDetail>();
        }

        public int StatusId { get; set; }
        public string? StatusDescription { get; set; }

        public virtual ICollection<UserDetail> UserDetails { get; set; }
    }
}
