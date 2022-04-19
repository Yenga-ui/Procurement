using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class CdfEvaluationmethod
    {
        public int Id { get; set; }
        public string? Method { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
