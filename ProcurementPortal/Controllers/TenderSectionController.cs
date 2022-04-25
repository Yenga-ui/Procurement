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

            tenderSection.TextResponse = 1;
            tenderSection.SupportingDocumentation = 1;
                        /*if (!ModelState.IsValid)
            {
                return Ok(
                    new
                    {
                        success = false,
                        message = "Validation Failed"
                    });
            }*/
             String tenderID= HttpContext.Session.GetString("tenderID");
          
            HttpContext.Session.SetString("tenderID",tenderID);
            tenderSection.TenderId=Int32.Parse(tenderID);
            CdfTenderSection tSection= TenderSectionDataService.Save(tenderSection);

            HttpContext.Session.SetString("tenderSecID", tSection.Id.ToString());


            if (tSection == null)
                throw new Exception("Failed to save");

            return Ok(
                    new
                    {
                        success = true,
                        message = "Successfully added",
                        payload = tSection
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


    [HttpPost]
    [Route("tender-section/AddSection")]
    public ActionResult AddSection([FromBody] CdfTenderSectionSub tenderSectionSub)
    {
        CdfTenderSectionSub cdfTenderSectionSub= new CdfTenderSectionSub();
        try
        {
            if (tenderSectionSub.Description == "")
            {

                tenderSectionSub.Description = tenderSectionSub.Title;
            }

            tenderSectionSub.TenderId =Int32.Parse( HttpContext.Session.GetString("tenderID"));
            tenderSectionSub.TenderSectionId = Int32.Parse(HttpContext.Session.GetString("tenderSecID"));
            if (tenderSectionSub.Title.Contains("Financial"))
                tenderSectionSub.NumberInput = "yes";

            cdfTenderSectionSub = TenderSectionDataService.SaveSub(tenderSectionSub);

            return Ok(new
            {


                success = true,
                message = cdfTenderSectionSub.Title + " Successfully added",
                payload = cdfTenderSectionSub
            });


        }
        catch(Exception ex)
        {

            return Ok(
                new
                {
                    success = false,
                    message = "Failed to add Sub Section to Section",
                    

                });
                
                
                


            }
        }

    // public ActionResult CreateSub([FromBody] CdfTend)
}