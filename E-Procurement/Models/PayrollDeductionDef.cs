using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class PayrollDeductionDef
    {
        public int DefId { get; set; }
        public string DeductionCode { get; set; }
        public string DeductionDecsription { get; set; }
        public string Formula { get; set; }
        public string Status { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public int LineFlag { get; set; }
    }
}
