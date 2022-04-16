using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class Bank
    {
        public Bank()
        {
            BankBranches = new HashSet<BankBranch>();
        }

        public int BankId { get; set; }
        public string Code { get; set; }
        public string BankName { get; set; }
        public string Status { get; set; }
        public DateTime? LastChanged { get; set; }

        public virtual ICollection<BankBranch> BankBranches { get; set; }
    }
}
