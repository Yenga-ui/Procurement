using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using E_Procurement.Models;

namespace E_Procurement.Pages.ProcPlans
{
    public class EditModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public EditModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CdfPlanItems CdfPlanItems { get; set; }



        [BindProperty]
        public IList <CdfPlanItems> CdfPlanItemsList { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CdfPlanItems = await _context.CdfPlanItems.FirstOrDefaultAsync(m => m.Id == id);
            CdfPlanItemsList= await _context.CdfPlanItems.Where(m => m.ProcPlanId == id).ToListAsync();

            if (CdfPlanItemsList == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CdfPlanItems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CdfPlanItemsExists(CdfPlanItems.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CdfPlanItemsExists(int id)
        {
            return _context.CdfPlanItems.Any(e => e.Id == id);
        }
    }
}
