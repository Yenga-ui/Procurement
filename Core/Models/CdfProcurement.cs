using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfProcurement
    {
        public int Id { get; set; }
        public string? Method { get; set; }
        public int? NumberOfBidders { get; set; }
    }
}
