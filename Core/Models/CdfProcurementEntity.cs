using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfProcurementEntity
    {
        public int Id { get; set; }
        public string EntityName { get; set; }
        public string Type { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}
