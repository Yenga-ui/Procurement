using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class CreateTenderSectionViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int? SupportingDocumentation { get; set; }
        public int? TextResponse { get; set; }
        public string? Description { get; set; }
    }
}
