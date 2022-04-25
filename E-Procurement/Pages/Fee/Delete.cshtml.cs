using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E_Procurement.Models;

namespace E_Procurement.Pages.Fee
{
    public class DeleteModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public DeleteModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CdfSupplierFee CdfSupplierFee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CdfSupplierFee = await _context.CdfSupplierFee.FirstOrDefaultAsync(m => m.Id == id);

            if (CdfSupplierFee == null)
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

            CdfSupplierFee = await _context.CdfSupplierFee.FindAsync(id);

            if (CdfSupplierFee != null)
            {
                _context.CdfSupplierFee.Remove(CdfSupplierFee);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
