using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using E_Procurement.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Procurement.Pages.ProcPlans
{
    public class ProcPlanItemModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public ProcPlanItemModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CdfProcPlanItems = await _context.CdfPlanItems.Where(m => m.ProcPlanId == id).ToListAsync();

            if (CdfProcPlanItems == null)
            {
                return NotFound();
            }
            return Page();
        }





        [BindProperty]
        public IList<CdfPlanItems> CdfProcPlanItems { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.CdfProcPlan.Add(CdfProcPlan);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
