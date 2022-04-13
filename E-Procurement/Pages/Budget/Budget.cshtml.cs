using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using E_Procurement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace E_Procurement.Pages.Budget
{
    public class BudgetModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;
        private List<CsvLine> lines = new List<CsvLine>();
        private IHostingEnvironment _environment;
        public BudgetModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

   
         public async Task<IActionResult> OnGetAsync(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
          
            cdfBudgetExpenses = await _context.CdfBudgetExpense.Where(m => m.BudgetId == id).ToListAsync();
            cdfBudgetRevenues= await _context.CdfBudgetRevenue.Where(m => m.BudgetId == id).ToListAsync();
            return Page();
        } 

        [BindProperty]
        public CdfBudget CdfBudget { get; set; }

        [BindProperty]
        public IFormFile Upload { get; set; }


        [BindProperty]
        public String expName { get; set; }
        [BindProperty]
        public String id { get; set; }
        [BindProperty]
        public String expNumber { get; set; }

        [BindProperty]
        public String code { get; set; }

        [BindProperty]
        public String revenueName { get; set; }
        [BindProperty]
        public String revenueNumber { get; set; }
       




        public IList<CdfBudgetExpense> cdfBudgetExpenses { get; set; }


        public IList<CdfBudgetRevenue> cdfBudgetRevenues { get; set; }
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CdfBudget.Add(CdfBudget);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        public async Task<IActionResult> OnPostAddExpenseAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

    
            CdfBudgetExpense cdfBudgetExpense = new CdfBudgetExpense();

            cdfBudgetExpense.Amount = this.expNumber;
            cdfBudgetExpense.Description = this.expName;
            cdfBudgetExpense.Code = this.code;

            cdfBudgetExpense.BudgetId = Int32.Parse(this.id);
            _context.CdfBudgetExpense.Add(cdfBudgetExpense);

            HttpContext.Session.SetString("id", id);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Budget", new { id = id });

        }

        public async Task<IActionResult> OnPostAddRevenueAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            CdfBudgetRevenue cdfBudgetRevenue = new CdfBudgetRevenue();

            cdfBudgetRevenue.BudgetId = Int32.Parse(id);
            cdfBudgetRevenue.Amount = revenueNumber;
            cdfBudgetRevenue.Description = revenueName;
            _context.CdfBudgetRevenue.Add(cdfBudgetRevenue);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Budget", new { id = id });
        }


        public async Task<IActionResult> OnPostUploadExpenseAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            try
            {
                var file = Path.Combine(_environment.ContentRootPath, "uploads", Upload.FileName);
                using (var fs = new StreamReader(Upload.FileName))
                {
                    // I just need this one line to load the records from the file in my List<CsvLine>
                    lines = new CsvHelper.CsvReader((CsvHelper.IParser)fs).GetRecords<CsvLine>().ToList();
                }
                foreach(CsvLine line in lines)
                {

                    Console.WriteLine(line.description);
                }
            }
            catch(Exception ex)
            {


            }

            return RedirectToPage("./Budget", new { id = id });
        }

    }
}
