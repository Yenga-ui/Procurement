using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class PromotionHistory
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string OldPositionCode { get; set; }
        public string NewPositionCode { get; set; }
        public DateTime PromotionDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
    }
}
