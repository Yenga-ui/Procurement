using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfTenderSectionSub
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int? TenderId { get; set; }
        public int? TenderSectionId { get; set; }
        public string? NumberInput { get; set; }
        public string? SupportingDocumentation { get; set; }
        public string? TextResponse { get; set; }
        public string? Description { get; set; }
    }
}
