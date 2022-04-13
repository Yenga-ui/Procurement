using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class TitleDescription
    {
        public TitleDescription()
        {
            Entity = new HashSet<Entity>();
        }

        public int TitleId { get; set; }
        public string TitleDescription1 { get; set; }

        public virtual ICollection<Entity> Entity { get; set; }
    }
}
