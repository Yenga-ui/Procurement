using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class CdfBudgetExpense
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Amount { get; set; }
        public string Currency { get; set; }
        public int? BudgetId { get; set; }
        public string Code { get; set; }
    }
}
