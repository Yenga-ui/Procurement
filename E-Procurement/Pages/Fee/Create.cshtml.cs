using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using E_Procurement.Models;

namespace E_Procurement.Pages.Fee
{
    public class CreateModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public CreateModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CdfSupplierFee CdfSupplierFee { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CdfSupplierFee.Add(CdfSupplierFee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
