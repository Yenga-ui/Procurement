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

namespace E_Procurement.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;
        private IMailService mailService;

        public CreateModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            CdfUsers = await _context.CdfUser.ToListAsync();
            populateDepartmet(_context);
            populateRole(_context);
            populateDepartmet(_context);
            populateUserType(_context);
            populateStatus(_context);
            
        }
        [BindProperty]
        public CdfUser CdfUser { get; set; }

        public IList<CdfUser> CdfUsers { get; set; }
        public SelectList usertype { get; set; }

        public SelectList status { get; set; }

        public SelectList role { get; set;}


        public SelectList department { get; set; }


        public void populateDepartmet(MyPayrollContext _context,object selectedDepartment = null)
        {

            var departmentQuery = from c in _context.Department
                                orderby c.LongDescription
                                select c;

            this.department = new SelectList(departmentQuery.AsNoTracking(), "LongDescription", "LongDescription", selectedDepartment);
        }

        public void populateRole(MyPayrollContext _context, object selectedDepartment = null)
        {

            var departmentQuery = from c in _context.CdfRole
                                  orderby c.Id
                                  select c;

            this.role = new SelectList(departmentQuery.AsNoTracking(), "Role", "Role", selectedDepartment);
        }

        public void populateStatus(MyPayrollContext _context, object selectedDepartment = null)
        {

            var departmentQuery = from c in _context.CdfStatus
                                  orderby c.Id
                                  select c;

            this.status = new SelectList(departmentQuery.AsNoTracking(), "Status", "Status", selectedDepartment);
        }
        public void populateUserType(MyPayrollContext _context, object selectedDepartment = null)
        {

            var departmentQuery = from c in _context.CdfUserType
                                  orderby c.Type
                                  select c;

            this.usertype = new SelectList(departmentQuery.AsNoTracking(), "Type", "Type", selectedDepartment);
        }
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
             
           
            _context.CdfUser.Add(CdfUser);
            await _context.SaveChangesAsync();
            MailRequest mailRequest = new MailRequest(CdfUser.Email, "User Registration", CdfUser.Username + " Kindly note that your account has been created. You can log in to the application using your email " + CdfUser.Email + " and default password of Test1234. Click https://localhost:44313/Login/Login to log in");
            return RedirectToPage("./Index");
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
