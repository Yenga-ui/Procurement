using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfBid
    {
        public int Id { get; set; }
        public int? SupplierId { get; set; }
        public int? TenderId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Details { get; set; }
    }
}
