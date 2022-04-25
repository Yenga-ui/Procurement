using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfAssetType
    {
        public int Id { get; set; }
        public string? AssetType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
