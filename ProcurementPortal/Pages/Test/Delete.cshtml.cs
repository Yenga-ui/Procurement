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
    public class DeleteModel : PageModel
    {
        private readonly Core.Models.MyPayrollContext _context;

        public DeleteModel(Core.Models.MyPayrollContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CdfTenderSection = await _context.CdfTenderSections.FindAsync(id);

            if (CdfTenderSection != null)
            {
                _context.CdfTenderSections.Remove(CdfTenderSection);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
