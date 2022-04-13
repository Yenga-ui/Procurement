using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class StatusDescription
    {
        public int StatusId { get; set; }
        public string StatusCode { get; set; }
        public string StausDescription { get; set; }
    }
}
