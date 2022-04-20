using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class CdfTenderSection
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? SupportingDocumentation { get; set; }
        public int? TextResponse { get; set; }
        public int? TenderId { get; set; }
    }
}
