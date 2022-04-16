using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int? ConsituencyId { get; set; }
        public int? Type { get; set; }
        public int? Status { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public int? RoleId { get; set; }
        public int? DepartmentId { get; set; }
        public byte[] Logo { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
