using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class UserPasswordResets
    {
        public int ResetId { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ResetToken { get; set; }
        public DateTime? ResetDate { get; set; }
        public int? TokenStatusId { get; set; }

        public virtual UserDetail User { get; set; }
    }
}
