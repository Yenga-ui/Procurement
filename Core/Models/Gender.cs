using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class Gender
    {
        public int GenderId { get; set; }
        public string? Code { get; set; }
        public string? LongDescription { get; set; }
    }
}
