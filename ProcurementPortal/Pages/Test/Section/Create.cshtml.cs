using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Core.Models;

namespace Portal.Pages.Test.Section
{
    public class CreateModel : PageModel
    {
        private readonly Core.Models.MyPayrollContext _context;

        public CreateModel(Core.Models.MyPayrollContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CdfTenderSection CdfTenderSection { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CdfTenderSections.Add(CdfTenderSection);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
