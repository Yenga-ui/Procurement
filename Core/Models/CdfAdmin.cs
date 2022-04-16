using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfAdmin
    {
        public int Id { get; set; }
        public int? OrganizationId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? Active { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
    }
}
