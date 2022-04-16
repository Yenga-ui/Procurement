using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfLevel
    {
        public int Id { get; set; }
        public int? LevelInOrganization { get; set; }
        public DateTime DateCreated { get; set; }
        public int? NumberOfUsers { get; set; }
    }
}
