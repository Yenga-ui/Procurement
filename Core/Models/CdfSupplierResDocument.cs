using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfSupplierResDocument
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Path { get; set; }
        public int SectionId { get; set; }
    }
}
