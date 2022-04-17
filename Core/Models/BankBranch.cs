using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class BankBranch
    {
        public int BranchId { get; set; }
        public int BankId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string Status { get; set; }
        public DateTime? LastChanged { get; set; }

        public virtual Bank Bank { get; set; }
    }
}
