using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class CdfTenderSectionSub
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? TenderId { get; set; }
        public int? TenderSectionId { get; set; }
        public string NumberInput { get; set; }
        public string SupportingDocumentation { get; set; }
        public string TextResponse { get; set; }
        public string Description { get; set; }
    }
}
