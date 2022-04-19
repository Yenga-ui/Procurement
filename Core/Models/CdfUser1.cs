using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfUser1
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public byte[]? Logo { get; set; }
        public int? OrganizationId { get; set; }
        public int? RoleId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? CreatedBy { get; set; }
        public string? ProcEntity { get; set; }
    }
}
