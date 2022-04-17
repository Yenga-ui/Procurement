using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ProcurementPlanItem
    {
        [Required]
        public string Class { get; set; }
        [Required]
        public string UNSPSC { get; set; }
        [Required]
        public string Description { get; set; }
        public string Ref_No { get; set; }
        public string? Project_Code { get; set; }
        public string? Unit_of_Measure { get; set; }
        public string? Quantity { get; set; }
        [Required]
        public string Source_of_Funds { get; set; }
        public string Prequalification { get; set; }
        public string Procurement_Method { get; set; }
        [Required]
        public string Publication { get; set; }
        [Required]
        public string Award { get; set; }
        [Required]
        public string Start { get; set; }
        public string? Comments { get; set; }
        public string? Type_of_Entry { get; set; }

    }
}
