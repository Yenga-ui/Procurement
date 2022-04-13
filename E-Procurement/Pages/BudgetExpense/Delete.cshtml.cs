using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E_Procurement.Models;

namespace E_Procurement.Pages.BudgetExpense
{
    public class DeleteModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public DeleteModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CdfBudgetExpense CdfBudgetExpense { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CdfBudgetExpense = await _context.CdfBudgetExpense.FirstOrDefaultAsync(m => m.Id == id);

            if (CdfBudgetExpense == null)
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

            CdfBudgetExpense = await _context.CdfBudgetExpense.FindAsync(id);

            if (CdfBudgetExpense != null)
            {
                _context.CdfBudgetExpense.Remove(CdfBudgetExpense);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
