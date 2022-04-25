using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfRole
    {
        public int Id { get; set; }
        public string? Role { get; set; }
        public int? LevelId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? CreatedBy { get; set; }
    }
}
