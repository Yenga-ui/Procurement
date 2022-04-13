using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class IdnumberType
    {
        public IdnumberType()
        {
            Entity = new HashSet<Entity>();
        }

        public int IdnumberTypeId { get; set; }
        public string Idcode { get; set; }
        public string LongDescription { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Entity> Entity { get; set; }
    }
}
