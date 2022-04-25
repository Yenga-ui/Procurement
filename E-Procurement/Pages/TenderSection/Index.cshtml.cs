using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E_Procurement.Models;
using Microsoft.AspNetCore.Http;

namespace E_Procurement.Pages.TenderSection
{
    public class IndexModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public IndexModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

        public IList<CdfTenderSection> CdfTenderSection { get;set; }

        public async Task<IActionResult> OnGetAsync(int ? id)
            {
            try
            {
                string username = HttpContext.Session.GetString("username");

                if (_context.CdfSupplierTenderPayment.Where(x => x.SupplierCode == username).Count() == 0)
                {

                    return RedirectToPage("../Register/Payment");
                }
                else
                {
                    CdfTenderSection = await _context.CdfTenderSection.Where(m => m.TenderId == id).ToListAsync();
                    return Page();
                }
            }
            catch (Exception ex)
            {
              return  RedirectToPage("../SupplierTender/");
            }
            
        }
        public async Task OnPostAsync()
        {

            String name = Request.Form["textReponse"];
            String id= Request.Form["itemId"];
            CdfSupplierResponse response=new CdfSupplierResponse();
            response.TextResponse = name;
            response.TenderId = Int32.Parse(id);
            _context.CdfSupplierResponse.Add(response);

            await _context.CdfSupplierResponse.AddAsync(response);

            _context.SaveChanges();
        }
    }
}
