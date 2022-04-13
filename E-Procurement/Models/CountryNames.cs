using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace E_Procurement.Models
{
    public partial class CountryNames
    {
        public CountryNames()
        {
            Entity = new HashSet<Entity>();
        }

        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public int? CountryPhoneCode { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Entity> Entity { get; set; }
    }
}
