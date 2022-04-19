using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfAsset
    {
        public int Id { get; set; }
        public string? Asset { get; set; }
        public string? AssetType { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? CreatedBy { get; set; }
    }
}
