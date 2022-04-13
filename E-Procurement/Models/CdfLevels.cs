using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class CdfLevels
    {
        public int Id { get; set; }
        public int? LevelInOrganization { get; set; }
        public DateTime DateCreated { get; set; }
        public int? NumberOfUsers { get; set; }
    }
}
