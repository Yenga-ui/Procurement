using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class EmployeeRemuneration
    {
        public int RemunerationId { get; set; }
        public int EmployeeId { get; set; }
        public decimal? RemunerationAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Reason { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string UserId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
