using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfExpenseType
    {
        public int Id { get; set; }
        public string? ExpenseType { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
