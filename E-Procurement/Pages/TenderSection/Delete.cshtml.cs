using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E_Procurement.Models;

namespace E_Procurement.Pages.TenderSection
{
    public class DeleteModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public DeleteModel(E_Procurement.Models.MyPayrollContext context)
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

            CdfTenderSection = await _context.CdfTenderSection.FirstOrDefaultAsync(m => m.Id == id);

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

            CdfTenderSection = await _context.CdfTenderSection.FindAsync(id);

            if (CdfTenderSection != null)
            {
                _context.CdfTenderSection.Remove(CdfTenderSection);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
