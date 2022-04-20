using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Core.Models;

namespace Portal.Pages.Test
{
    public class CreateModel : PageModel
    {
        private readonly Core.Models.MyPayrollContext _context;

        public CreateModel(Core.Models.MyPayrollContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CdfTenderSection CdfTenderSection { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public ActionResult OnPost()
        {

            String name= Request.Form["Title"];
            if (!ModelState.IsValid)
            {
                return Page();
            }

<<<<<<< HEAD
            _context.CdfTenderSections.Add(CdfTenderSection);
            await _context.SaveChangesAsync();
=======
           // _context.CdfTenders.Add(CdfTender);
          //  await _context.SaveChangesAsync();
>>>>>>> 841d8a7c0bee35167b0eb469852934daac48961c

            return RedirectToPage("./Index");
        }
    }
}
