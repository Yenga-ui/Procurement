using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers;

public class TenderSectionController : Controller
{
    private readonly ITenderSectionDataService TenderSectionDataService;

    public TenderSectionController(ITenderSectionDataService tenderSectionService)
    {
        TenderSectionDataService = tenderSectionService;
    }
    // GET
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    [Route("tender-section/create")]
    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [Route("tender-section/create")]
    public ActionResult Create([FromBody] CdfTenderSection tenderSection)
    {
        try
        {
            /*if (!ModelState.IsValid)
            {
                return Ok(
                    new
                    {
                        success = false,
                        message = "Validation Failed"
                    });
            }*/

            var tender = TenderSectionDataService.Save(tenderSection);

            if (tender == null)
                throw new Exception("Failed to save");

            return Ok(
                    new
                    {
                        success = true,
                        message = "Successfully added",
                        payload = tender
                    }
                );
        }
        catch (Exception)
        {
            return Ok(
                    new
                    {
                        success = false,
                        message = "Failed to add"
                    }
                );
        }
    }
}