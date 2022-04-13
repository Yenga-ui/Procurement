using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using E_Procurement.Models;
using Microsoft.EntityFrameworkCore;
using E_Procurement.Services;

namespace E_Procurement.Pages.Tender
{
    public class CreateModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;
        private IMailService mailService;
        public CreateModel(E_Procurement.Models.MyPayrollContext context,IMailService mailService)
        {
            _context = context;
            this.mailService = mailService;
        }

        public async Task OnGetAsync()
        {
            PopulateCategory(_context);
            PopulateEvaluationMethod(_context);
            PopulateDepartments(_context);
            PopulateTenderProcedure(_context);
            PopulatebudgetExpenses(_context);
            populateBudget(_context);
            suppliers = await _context.SupplierRegistation.ToListAsync();
           
        }

        [BindProperty]
        public CdfTender CdfTender { get; set; }
        [BindProperty]
        public string selectedFilter { get; set; }
        public SelectList budget { get; set; }

    
        public SelectList budgetExpenses { get; set; }

        public SelectList Category { get; set; }

        public SelectList procurementMethod { get; set; }

        public SelectList tenderProcedure { get; set; }

        public SelectList department { get; set; }

        public SelectList tenderProcurementTechnique { get; set; }


        public SelectList tenderEvaluationMethod { get; set; }

        
        public IList<SupplierRegistation> suppliers { get; set; }
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostSubmitAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

         
            _context.CdfTender.Add(CdfTender);
            await _context.SaveChangesAsync();

            // send email to all registered suppliers
           suppliers= await _context.SupplierRegistation.ToListAsync();
            foreach (SupplierRegistation reg in suppliers)
            {

               MailRequest mailRequest = new MailRequest(reg.Email, "New Tender On System, "+CdfTender.ShortDescription, reg.OrganizationName + ", Kindly note that a new Tender for the supply/procurement of "+CdfTender.Category+". Kindly log in to the e-procurement system for more details. Click https://localhost:44313/Login/Login to log in");

                SendMail(mailRequest);
            }
            return RedirectToPage("./Index");
        

        }


        public IActionResult OnPost()
        {

            ModelState.Remove("selectedFilter");
            PopulatebudgetExpenses(_context);
            

            return Page();


        }

    
        public void PopulateCategory(MyPayrollContext _context, object selectedCategory=null)
        {

            var categoryQuery = from c in _context.CdfTenderCategory
                                orderby c.Category
                                select c;

            this.Category = new SelectList(categoryQuery.AsNoTracking(), "Category", "Category", selectedCategory);
                               
                               
                              
        }
        public void PopulatebudgetExpenses(MyPayrollContext _context, object selectedCategory = null)
        {

            var categoryQuery = from c in _context.CdfBudgetExpense
                                orderby c.Id
                                select c;

            this.budgetExpenses = new SelectList(categoryQuery.AsNoTracking(), "Id", "Code", selectedCategory);



        }

        public void populateBudget(MyPayrollContext _context, object selectedCategory = null)
        {

            var budget = from c in _context.CdfBudget
                         orderby c.BudgetName
                         select c;
            this.budget = new SelectList(budget.AsNoTracking(), "Id", "BudgetName");
        }
            public void PopulateEvaluationMethod(MyPayrollContext _context, object selectedCategory = null)
        {

            var categoryQuery = from c in _context.CdfEvaluationmethod
                                orderby c.Method
                                select c;

            this.tenderEvaluationMethod = new SelectList(categoryQuery.AsNoTracking(), "Method", "Method", selectedCategory);



        }
        public void PopulateDepartments(MyPayrollContext _context, object selectedCategory = null)
        {

            var categoryQuery = from c in _context.CdfDepartment
                                orderby c.Department
                                select c;

            this.department = new SelectList(categoryQuery.AsNoTracking(), "Department", "Department", selectedCategory);



        }
        public void PopulateTenderProcedure(MyPayrollContext _context, object selectedCategory = null)
        {

            var categoryQuery = from c in _context.CdfTenderProcedure
                                orderby c.TenderProcedure
                                select c;

            this.tenderProcedure = new SelectList(categoryQuery.AsNoTracking(), "TenderProcedure", "TenderProcedure", selectedCategory);

        }
        public async void SendMail(MailRequest request)
        {
            try
            {
                await mailService.SendEmailAsync(request);
                return;
            }
            catch (Exception ex)
            {

                throw;

            }

        }
    }
}
