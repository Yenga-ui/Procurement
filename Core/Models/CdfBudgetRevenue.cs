using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfBudgetRevenue
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Amount { get; set; }
        public string Currency { get; set; }
        public int? BudgetId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
