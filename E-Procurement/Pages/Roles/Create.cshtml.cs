using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using E_Procurement.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Procurement.Pages.Roles
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
            populateLevel(_context);
            return Page();
        }

        [BindProperty]
        public CdfRole CdfRole { get; set; }

        public SelectList level { get; set; }

        public void populateLevel(MyPayrollContext _context, object selectedLevel = null)
        {

            var levelQuery = from c in _context.CdfLevels
                                  orderby c.LevelInOrganization
                                  select c;

            this.level = new SelectList(levelQuery.AsNoTracking(), "LevelInOrganization", "LevelInOrganization", selectedLevel);
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CdfRole.Add(CdfRole);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
