using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class TitleDescription
    {
        public TitleDescription()
        {
            Entities = new HashSet<Entity>();
        }

        public int TitleId { get; set; }
        public string TitleDescription1 { get; set; }

        public virtual ICollection<Entity> Entities { get; set; }
    }
}
