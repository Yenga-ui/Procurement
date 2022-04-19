using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfBudgetPeriod
    {
        public int Id { get; set; }
        public string? Period { get; set; }
        public int? BudgetId { get; set; }
    }
}
