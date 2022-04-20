using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers;

public class SupplierController : Controller
{
    private readonly ISupplierDataService SupplierDataService;
    private readonly IDropDownService DropDownService;

    public SupplierController(ISupplierDataService supplierDataService,
        IDropDownService dropDownService)
    {
        SupplierDataService = supplierDataService;
        DropDownService = dropDownService;
    }
    // GET
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public ActionResult Tenders()
    {
        var tenderItems = SupplierDataService.GetTenders();
        return View(tenderItems);
    }

    [Route("tenderSections")]
    public ActionResult GetSections()
    {
        var jsonData = DropDownService.tenderSections();
        return Ok(
            new
            {
                success = true,
                message = "Successfully fetched",
                payload = jsonData,
            });
    }

    [HttpGet]
    [Route("supplier/tender/bid")]
    public ActionResult Bid()
    {
        return View();
    }
}