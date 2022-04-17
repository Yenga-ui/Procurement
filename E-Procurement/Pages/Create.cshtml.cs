using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using E_Procurement.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Procurement.Pages
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
            CdfProcurementEntities = await _context.CdfProcurementEntity.ToListAsync();
            PopulateEntityType(_context);

        }

        [BindProperty]
        public CdfProcurementEntity CdfProcurementEntity { get; set; }


        [BindProperty]
        public String title { get; set; }
        [BindProperty]
        public String description { get; set; }
        [BindProperty]
        public String email { get; set; }
        [BindProperty]
        public String type { get; set; }
        public SelectList EntityType { get; set; }

        public void PopulateEntityType(MyPayrollContext _context, object selectedCategory = null)
        {

            var categoryQuery = from c in _context.CdfProcurementEntityType
                                orderby c.Type
                                select c;

            this.EntityType = new SelectList(categoryQuery.AsNoTracking(), "Type", "Type", selectedCategory);



        }
        public IList<CdfProcurementEntity> CdfProcurementEntities { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            CdfProcurementEntity.Description = Request.Form["description"];
            CdfProcurementEntity.Email = Request.Form["email"];
            CdfProcurementEntity.Type = Request.Form["type"];
            CdfProcurementEntity.EntityName = Request.Form["entity"];


            _context.CdfProcurementEntity.Add(CdfProcurementEntity);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Create");
        }

        public async Task<IActionResult> OnPostDeleteAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            CdfProcurementEntity.Description = Request.Form["description"];
            CdfProcurementEntity.Email = Request.Form["email"];
            CdfProcurementEntity.Type = Request.Form["type"];
            CdfProcurementEntity.EntityName = Request.Form["entity"];


            _context.CdfProcurementEntity.Add(CdfProcurementEntity);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Create");
        }

    }
}
