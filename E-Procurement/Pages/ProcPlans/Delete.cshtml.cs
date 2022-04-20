using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E_Procurement.Models;

namespace E_Procurement.Pages.ProcPlans
{
    public class DeleteModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public DeleteModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CdfPlanItems CdfPlanItems { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CdfPlanItems = await _context.CdfPlanItems.FirstOrDefaultAsync(m => m.Id == id);

            if (CdfPlanItems == null)
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

            CdfPlanItems = await _context.CdfPlanItems.FindAsync(id);

            if (CdfPlanItems != null)
            {
                _context.CdfPlanItems.Remove(CdfPlanItems);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
