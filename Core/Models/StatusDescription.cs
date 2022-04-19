using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class StatusDescription
    {
        public int StatusId { get; set; }
        public string? StatusCode { get; set; }
        public string? StausDescription { get; set; }
    }
}
