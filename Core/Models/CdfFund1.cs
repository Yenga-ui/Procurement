using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfFund1
    {
        public int Id { get; set; }
        public string Fund { get; set; }
        public string Amount { get; set; }
        public string Currency { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
