using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
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
