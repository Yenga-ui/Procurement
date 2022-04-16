using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
