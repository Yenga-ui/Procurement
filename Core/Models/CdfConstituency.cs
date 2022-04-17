using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfConstituency
    {
        public int Id { get; set; }
        public string Constituency { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
    }
}
