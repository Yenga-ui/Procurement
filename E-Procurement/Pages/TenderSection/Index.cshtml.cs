using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E_Procurement.Models;

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

        public async Task OnGetAsync(int ? id)
        {
            try
            {
                CdfTenderSection = await _context.CdfTenderSection.Where(m => m.TenderId == id).ToListAsync();
            }
            catch (Exception ex)
            {
               RedirectToPage("../SupplierTender/");
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
