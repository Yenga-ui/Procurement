using E_Procurement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq;

namespace E_Procurement.Pages.Register
{
    public class PaymentTenderModel : PageModel
    {
        private readonly MyPayrollContext db;

        public PaymentTenderModel(MyPayrollContext context)
        {

            db = context;
           
        }

       public string amount { get; set; }

       public string supplierName { get; set; }

       public string supplierEmail { get; set; }

        public string supplierRegistration { get; set; }

        public Payment payment { get; set; }
        public void OnGet()

        {
            try
            {
                Payment payment = new Payment();
                CdfSupplierFee cdfSupplierFee = new CdfSupplierFee();
                string username = HttpContext.Session.GetString("username").ToString();
                SupplierRegistation supp = db.SupplierRegistation.Where(u => u.Email == username).FirstOrDefault();
                cdfSupplierFee = db.CdfSupplierFee.FirstOrDefault(u => u.Active == 1);
                amount = cdfSupplierFee.SupplierFee.ToString();
                supplierRegistration = supp.SupplierRegistrationCode;
                supplierName = supp.OrganizationName;
                amount = amount;
                supplierEmail = HttpContext.Session.GetString("username").ToString();
            }

            catch(Exception ex)
            {
                throw new Exception(ex.Message);    

            }

        }
    }
}
