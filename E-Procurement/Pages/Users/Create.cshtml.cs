using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using E_Procurement.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Procurement.Pages.Users
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
            populateDepartmet(_context);
            populateRole(_context);
            populateDepartmet(_context);
            populateUserType(_context);
            populateStatus(_context);
            return Page();
        }

        [BindProperty]
        public CdfUser CdfUser { get; set; }

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

            return RedirectToPage("./Index");
        }
    }
}
