using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class CdfStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
