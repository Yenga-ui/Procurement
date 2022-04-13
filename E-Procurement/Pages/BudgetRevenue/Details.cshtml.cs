using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E_Procurement.Models;

namespace E_Procurement.Pages.BudgetRevenue
{
    public class DetailsModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public DetailsModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

        public CdfBudgetRevenue CdfBudgetRevenue { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CdfBudgetRevenue = await _context.CdfBudgetRevenue.FirstOrDefaultAsync(m => m.Id == id);

            if (CdfBudgetRevenue == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
