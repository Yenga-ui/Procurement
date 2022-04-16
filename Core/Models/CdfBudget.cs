using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfBudget
    {
        public int Id { get; set; }
        public string Period { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? BudgetYear { get; set; }
        public string CreatedBy { get; set; }
        public string BudgetName { get; set; }
    }
}
