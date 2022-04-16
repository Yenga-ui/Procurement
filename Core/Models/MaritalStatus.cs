using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class MaritalStatus
    {
        public MaritalStatus()
        {
            Entities = new HashSet<Entity>();
        }

        public int MaritalStatusId { get; set; }
        public string LongDescription { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Entity> Entities { get; set; }
    }
}
