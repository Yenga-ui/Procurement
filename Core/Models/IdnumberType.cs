using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class IdnumberType
    {
        public IdnumberType()
        {
            Entities = new HashSet<Entity>();
        }

        public int IdnumberTypeId { get; set; }
        public string? Idcode { get; set; }
        public string? LongDescription { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<Entity> Entities { get; set; }
    }
}
