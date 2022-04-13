using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using E_Procurement.Models;

namespace E_Procurement.Controllers
{
    public class HomeController : Controller
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;
        public IActionResult Index()
        {
            return View();
        }
        public HomeController(E_Procurement.Models.MyPayrollContext context)
        {

            _context = context;
        }

        public List<CdfBudgetExpense> cdfBudgetExpenses(string id)
        {

            List<CdfBudgetExpense> cdfBudgetExpenses = _context.CdfBudgetExpense.Where(m => m.BudgetId.ToString() == id).ToList();

            return cdfBudgetExpenses;


        }
    }
}
