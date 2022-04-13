using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class Document
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public byte[] FileData { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int? SupplierId { get; set; }
        public int? TenderId { get; set; }
        public int? BidId { get; set; }
    }
}
