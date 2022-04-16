using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers
{
    public class ProcurementPlansController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
