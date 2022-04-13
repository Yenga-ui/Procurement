using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E_Procurement.Models;

namespace E_Procurement.Pages.TenderCategory
{
    public class DetailsModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public DetailsModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

        public CdfTenderCategory CdfTenderCategory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CdfTenderCategory = await _context.CdfTenderCategory.FirstOrDefaultAsync(m => m.Id == id);

            if (CdfTenderCategory == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
