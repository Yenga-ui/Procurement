using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfTenderSection
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public int? SupportingDocumentation { get; set; }
        public int? TextResponse { get; set; }
        public int? TenderId { get; set; }
    }
}
