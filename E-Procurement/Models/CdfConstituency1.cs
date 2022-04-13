using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class CdfConstituency1
    {
        public int Id { get; set; }
        public string Constituency { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
    }
}
