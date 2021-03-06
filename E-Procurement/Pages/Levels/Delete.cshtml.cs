using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E_Procurement.Models;

namespace E_Procurement.Pages.Levels
{
    public class DeleteModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public DeleteModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CdfLevels CdfLevels { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CdfLevels = await _context.CdfLevels.FirstOrDefaultAsync(m => m.Id == id);

            if (CdfLevels == null)
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

            CdfLevels = await _context.CdfLevels.FindAsync(id);

            if (CdfLevels != null)
            {
                _context.CdfLevels.Remove(CdfLevels);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
