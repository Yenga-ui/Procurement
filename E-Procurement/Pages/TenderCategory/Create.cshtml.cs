using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using E_Procurement.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Procurement.Pages.TenderCategory
{
    public class CreateModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public CreateModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            CdfTenderCategory = await _context.CdfTenderCategory.ToListAsync();
        }
        public IList<CdfTenderCategory> CdfTenderCategory { get; set; }

        [BindProperty]
        public CdfTenderCategory CdfTenderCategor { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CdfTenderCategory.Add(CdfTenderCategor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
