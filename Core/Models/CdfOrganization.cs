using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfOrganization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstAdminIdentityType { get; set; }
        public string FirstAdminId { get; set; }
        public string FirstAdminPhone { get; set; }
        public string FirstAdminEmail { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Activated { get; set; }
        public byte[] Logo { get; set; }
    }
}
