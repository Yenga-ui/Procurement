using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers;

public class TenderController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}