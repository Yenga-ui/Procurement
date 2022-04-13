using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using E_Procurement.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Procurement.Pages.Assets
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
            PopulateAssetType(_context);
            return Page();
        }

        [BindProperty]
        public CdfAsset CdfAsset { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CdfAsset.Add(CdfAsset);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        public SelectList assetType  { get; set; }

        public void PopulateAssetType(MyPayrollContext _context,
  object selectedDepartment = null)
        {

            var constituencyQuery = from d in _context.CdfAssetType
                                    orderby d.AssetType // Sort by name.
                                    select d;

            this.assetType = new SelectList(constituencyQuery.AsNoTracking(),
                        "AssetType", "AssetType", selectedDepartment);


        }
    }
}


