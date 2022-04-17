using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers;

public class TenderControlller : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}