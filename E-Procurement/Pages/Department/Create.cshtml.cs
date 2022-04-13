using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using E_Procurement.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Procurement.Pages.Department
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
            CdfDepartment = await _context.CdfDepartment.ToListAsync();
            
        }
        public IList<CdfDepartment> CdfDepartment { get; set; }
        [BindProperty]
        public CdfDepartment CdfDepartments { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CdfDepartment.Add(CdfDepartments);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
