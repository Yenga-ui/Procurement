using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Procurement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace E_Procurement.Pages.Login
{
    public class LoginModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

        public LoginModel(E_Procurement.Models.MyPayrollContext context)
        {

            _context = context;
        }

        [BindProperty]
        public String username { get; set; }

        [BindProperty]
        public String password { get; set; }


        public void OnGet()



        {

        }
        public IActionResult OnPost()


        {
            var userCount = 1;
            userCount = _context.SupplierRegistation.Where(p => p.Email == username).Count();
            if (userCount >= 1)
            {
                SupplierRegistation supplierRegistration = _context.SupplierRegistation.Where(p => p.Email == username).FirstOrDefault();




                Console.WriteLine("Data found");
                HttpContext.Session.SetString("username", username);
                HttpContext.Session.SetString("supplierID", supplierRegistration.Id.ToString());
                return RedirectToPage("/Login/Index");
            }

            else
            {
              
                return Page();
            }

        }


    }
}
