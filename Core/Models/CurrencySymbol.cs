using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CurrencySymbol
    {
        public int Id { get; set; }
        public string Country { get; set; } = null!;
        public string Currency { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Symbol { get; set; } = null!;
    }
}
