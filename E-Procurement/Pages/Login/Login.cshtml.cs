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
            userCount = _context.CdfUser.Where(p => p.Email == username).Count();
            if (userCount >= 1)
            {
                CdfUser cdfUser = _context.CdfUser.Where(p => p.Email == username).FirstOrDefault();



                if (cdfUser.RoleId == 2)
                {

                    Console.WriteLine("Data found");
                    HttpContext.Session.SetString("username", username);
                    HttpContext.Session.SetString("supplierID", cdfUser.Id.ToString());
                    return RedirectToPage("../Index");
                }
                if (cdfUser.RoleId == 3)
                {

                    Console.WriteLine("Data found");
                    HttpContext.Session.SetString("username", username);
                    HttpContext.Session.SetString("ID", cdfUser.Id.ToString());
                    return RedirectToPage("../Index");
                  }

                Console.WriteLine("Data found");
                HttpContext.Session.SetString("username", username);
                HttpContext.Session.SetString("supplierID", cdfUser.Id.ToString());
                return RedirectToPage("../Index");
            }

            else
            {
              
                return Page();
            }

        }


    }
}
