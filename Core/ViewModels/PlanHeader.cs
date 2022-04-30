using System.ComponentModel.DataAnnotations;

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
