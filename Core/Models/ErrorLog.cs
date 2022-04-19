using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class ErrorLog
    {
        public int Id { get; set; }
        public string? ErrorDescription { get; set; }
        public DateTime? DateLogged { get; set; }
        public string? UserId { get; set; }
    }
}
