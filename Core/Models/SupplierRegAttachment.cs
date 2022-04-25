using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class SupplierRegAttachment
    {
        public int Id { get; set; }
        public string? Attachment { get; set; }
        public string? AttachmentType { get; set; }
    }
}
