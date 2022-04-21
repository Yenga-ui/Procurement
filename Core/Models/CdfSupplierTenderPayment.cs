using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfSupplierTenderPayment
    {
        public int Id { get; set; }
        public string? SupplierCode { get; set; }
        public string? TenderCode { get; set; }
        public int? Paid { get; set; }
    }
}
