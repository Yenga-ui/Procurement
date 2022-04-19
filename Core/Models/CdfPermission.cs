using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfPermission
    {
        public int Id { get; set; }
        public string? Permission { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
