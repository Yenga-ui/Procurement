using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfBudgetExpense
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public string Amount { get; set; } = null!;
        public string? Currency { get; set; }
        public int? BudgetId { get; set; }
        public string Code { get; set; } = null!;
    }
}
