using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E_Procurement.Models;

namespace E_Procurement.Pages.Budget
{
    public class DeleteModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public DeleteModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CdfBudget CdfBudget { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CdfBudget = await _context.CdfBudget.FirstOrDefaultAsync(m => m.Id == id);

            if (CdfBudget == null)
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

            CdfBudget = await _context.CdfBudget.FindAsync(id);

            if (CdfBudget != null)
            {
                _context.CdfBudget.Remove(CdfBudget);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
