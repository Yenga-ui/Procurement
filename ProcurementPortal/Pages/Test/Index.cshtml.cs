using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Core.Models;

namespace Portal.Pages.Test
{
    public class IndexModel : PageModel
    {
        private readonly Core.Models.MyPayrollContext _context;

        public IndexModel(Core.Models.MyPayrollContext context)
        {
            _context = context;
        }

        public IList<CdfTenderSection> CdfTenderSection { get;set; }

        public async Task OnGetAsync()
        {
            CdfTenderSection = await _context.CdfTenderSections.ToListAsync();
        }
    }
}
