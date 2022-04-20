using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers;

public class SupplierController : Controller
{
    private readonly ISupplierDataService SupplierDataService;

    public SupplierController(ISupplierDataService supplierDataService)
    {
        SupplierDataService = supplierDataService;
    }
    // GET
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public ActionResult Tenders()
    {
        List<CdfPlanItem>? tenderItems = SupplierDataService.GetTenders();
        return View(tenderItems);
    }
}