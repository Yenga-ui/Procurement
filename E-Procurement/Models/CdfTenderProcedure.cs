using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class CdfTenderProcedure
    {
        public int Id { get; set; }
        public string TenderProcedure { get; set; }
        public int? NumberofBidders { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
