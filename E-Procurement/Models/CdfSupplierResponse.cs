using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class CdfSupplierResponse
    {
        public int Id { get; set; }
        public int TenderId { get; set; }
        public int SectionId { get; set; }
        public string TextResponse { get; set; }
        public int? SupplierId { get; set; }
    }
}
