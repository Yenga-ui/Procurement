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
    public class DetailsModel : PageModel
    {
        private readonly Core.Models.MyPayrollContext _context;

        public DetailsModel(Core.Models.MyPayrollContext context)
        {
            _context = context;
        }

        public CdfTenderSection CdfTenderSection { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CdfTenderSection = await _context.CdfTenderSections.FirstOrDefaultAsync(m => m.Id == id);

            if (CdfTenderSection == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
