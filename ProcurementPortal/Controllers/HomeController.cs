using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProcurementPortal.Models;

namespace ProcurementPortal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    [Route("username")]
    [HttpGet]
    public IActionResult username()
    {
        String username = HttpContext.Session.GetString("username");
        return Ok(
                      new
                      {
                          success = false,
                          message = "Successfully added",
                          payload = username,
                      });
    }
}