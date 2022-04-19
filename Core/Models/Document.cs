using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class Document
    {
        public long Id { get; set; }
        public string FileName { get; set; } = null!;
        public string? FileType { get; set; }
        public byte[] FileData { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int? SupplierId { get; set; }
        public int? TenderId { get; set; }
        public int? BidId { get; set; }
    }
}
