using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using E_Procurement.Models;
using E_Procurement.Services;
using Microsoft.EntityFrameworkCore;

namespace E_Procurement.Pages.Register
{
    public class CreateModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;
        private IMailService mailService;
        public CreateModel(E_Procurement.Models.MyPayrollContext context,IMailService mailServe)
        {
             mailService = mailServe;
            _context = context;
        }

        public IActionResult OnGet()
        {
            PopulateCountry(_context);
            PopulateCategory(_context);
            PopulateOrganizationType(_context);
            return Page();
        }

        public SelectList country { get; set; }

        public SelectList category { get; set; }

        public SelectList organizationType { get; set; }

        public void PopulateOrganizationType(MyPayrollContext _context,
        object selectedDepartment = null)
        {

            var constituencyQuery = from d in _context.CdfCompanyType
                                    orderby d.CompanyType // Sort by name.
                                    select d;

            this.organizationType = new SelectList(constituencyQuery.AsNoTracking(),
                        "CompanyType", "CompanyType", selectedDepartment);



        }

        public void PopulateCategory(MyPayrollContext _context,
       object selectedDepartment = null)
        {

            var constituencyQuery = from d in _context.CdfTenderCategory
                                    orderby d.Category // Sort by name.
                                    select d;

            this.category = new SelectList(constituencyQuery.AsNoTracking(),
                        "Category", "Category", selectedDepartment);


        }
        public void PopulateCountry(MyPayrollContext _context,
        object selectedDepartment = null)
        {

            var constituencyQuery = from d in _context.CountryNames
                                    orderby d.CountryName // Sort by name.
                                    select d;

            this.country = new SelectList(constituencyQuery.AsNoTracking(),
                        "CountryName", "CountryName", selectedDepartment);


        }
        [BindProperty]
        public SupplierRegistation SupplierRegistation { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Services.Reference reference = new Services.Reference();
            SupplierRegistation.SupplierRegistrationCode=reference.generateReferenceNumber(SupplierRegistation.OrganizationName);
            CdfUser user = new CdfUser();
            user.Username = SupplierRegistation.Email;
            user.Email = SupplierRegistation.Email;
            user.RoleId = 2;
            user.Status = 1;
            _context.CdfUser.Add(user);


            _context.SupplierRegistation.Add(SupplierRegistation);
            await _context.SaveChangesAsync();
            MailRequest mailRequest = new MailRequest(SupplierRegistation.Email, "Supplier Registration", SupplierRegistation.OrganizationName + " Kindly note that your account on the Procurement System has been created. You can log in to the application as a supplier using your supplier code "+ SupplierRegistation.SupplierRegistrationCode+ " and default password of Test1234. Click https://localhost:44313/Login/Login to log in");

            SendMail(mailRequest);
            return RedirectToPage("./Index");
        }
        

        public async void SendMail( MailRequest request)
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
