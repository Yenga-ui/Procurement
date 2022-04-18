using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class PlanHeader
    {
        public String title { set; get; }
        public String description { set; get; }
        [Required]
        public String year { set; get; }
    }
}
