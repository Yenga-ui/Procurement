using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class UserDetail
    {
        public UserDetail()
        {
            UserPasswordResets = new HashSet<UserPasswordResets>();
        }

        public int UserId { get; set; }
        public int? EmployeId { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public int? UserRoleId { get; set; }
        public int? ProfileStatus { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? LastLogon { get; set; }
        public int? FailedLoginAttempts { get; set; }
        public int? OrganizationId { get; set; }

        public virtual UserStatus ProfileStatusNavigation { get; set; }
        public virtual UserRoles UserRole { get; set; }
        public virtual ICollection<UserPasswordResets> UserPasswordResets { get; set; }
    }
}
