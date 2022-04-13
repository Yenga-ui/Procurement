using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E_Procurement.Models;

namespace E_Procurement.Pages.TenderProcedure
{
    public class DeleteModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public DeleteModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CdfTenderProcedure CdfTenderProcedure { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CdfTenderProcedure = await _context.CdfTenderProcedure.FirstOrDefaultAsync(m => m.Id == id);

            if (CdfTenderProcedure == null)
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

            CdfTenderProcedure = await _context.CdfTenderProcedure.FindAsync(id);

            if (CdfTenderProcedure != null)
            {
                _context.CdfTenderProcedure.Remove(CdfTenderProcedure);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
