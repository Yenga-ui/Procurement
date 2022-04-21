using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfSupplierResponse
    {
        public int Id { get; set; }
        public int TenderId { get; set; }
        public int SectionId { get; set; }
        public string? TextResponse { get; set; }
        public int? SupplierId { get; set; }
    }
}
