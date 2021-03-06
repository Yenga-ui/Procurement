using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E_Procurement.Models;

namespace E_Procurement.Pages.Department
{
    public class DeleteModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public DeleteModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CdfDepartment CdfDepartment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CdfDepartment = await _context.CdfDepartment.FirstOrDefaultAsync(m => m.Id == id);

            if (CdfDepartment == null)
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

            CdfDepartment = await _context.CdfDepartment.FindAsync(id);

            if (CdfDepartment != null)
            {
                _context.CdfDepartment.Remove(CdfDepartment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
