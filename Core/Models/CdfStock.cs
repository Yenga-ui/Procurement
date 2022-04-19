using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfStock
    {
        public int Id { get; set; }
        public string? Stock { get; set; }
        public string? StockCode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
