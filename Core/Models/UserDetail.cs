using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class UserDetail
    {
        public UserDetail()
        {
            UserPasswordResets = new HashSet<UserPasswordReset>();
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
        public virtual UserRole UserRole { get; set; }
        public virtual ICollection<UserPasswordReset> UserPasswordResets { get; set; }
    }
}
