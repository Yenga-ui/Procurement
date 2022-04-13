using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E_Procurement.Models;

namespace E_Procurement.Pages.TenderMethod
{
    public class DetailsModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public DetailsModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

        public CdfEvaluationmethod CdfEvaluationmethod { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CdfEvaluationmethod = await _context.CdfEvaluationmethod.FirstOrDefaultAsync(m => m.Id == id);

            if (CdfEvaluationmethod == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
