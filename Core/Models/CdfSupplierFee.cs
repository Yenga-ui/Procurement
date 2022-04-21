using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfSupplierFee
    {
        public int Id { get; set; }
        public decimal? SupplierFee { get; set; }
        public int? Active { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
