using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using E_Procurement.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Procurement.Pages.Entity
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
            PopulateEntityType(_context);
            return Page();
        }

        [BindProperty]
        public CdfProcurementEntity CdfProcurementEntity { get; set; }


   

        public SelectList EntityType { get; set; }

        public void PopulateEntityType(MyPayrollContext _context, object selectedCategory = null)
        {

            var categoryQuery = from c in _context.CdfProcurementEntityType
                                orderby c.Type
                                select c;

            this.EntityType = new SelectList(categoryQuery.AsNoTracking(), "Type", "Type", selectedCategory);



        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CdfProcurementEntity.Add(CdfProcurementEntity);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
