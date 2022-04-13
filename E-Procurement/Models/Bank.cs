using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class Bank
    {
        public Bank()
        {
            BankBranch = new HashSet<BankBranch>();
        }

        public int BankId { get; set; }
        public string Code { get; set; }
        public string BankName { get; set; }
        public string Status { get; set; }
        public DateTime? LastChanged { get; set; }

        public virtual ICollection<BankBranch> BankBranch { get; set; }
    }
}
