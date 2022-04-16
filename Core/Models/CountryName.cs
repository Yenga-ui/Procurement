using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CountryName
    {
        public CountryName()
        {
            Entities = new HashSet<Entity>();
        }

        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string CountryName1 { get; set; }
        public int? CountryPhoneCode { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Entity> Entities { get; set; }
    }
}
