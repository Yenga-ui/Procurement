using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core.Models;

namespace Portal.Pages.Test.Section
{
    public class EditModel : PageModel
    {
        private readonly Core.Models.MyPayrollContext _context;

        public EditModel(Core.Models.MyPayrollContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CdfTenderSection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CdfTenderSectionExists(CdfTenderSection.Id))
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

        private bool CdfTenderSectionExists(int id)
        {
            return _context.CdfTenderSections.Any(e => e.Id == id);
        }
    }
}
