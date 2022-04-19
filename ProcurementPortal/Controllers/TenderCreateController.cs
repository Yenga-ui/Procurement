using Core.Interfaces;
using Core.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace Portal.Controllers
{
    public class TenderCreateController : Controller
    {

        private readonly IDropDownService _dropDownService;
        private readonly IWebHostEnvironment Environment;
        private readonly ITenderService _enderService;

        public TenderCreateController(IDropDownService dropDownService, IWebHostEnvironment environment, ITenderService tenderService)
        {
            _dropDownService = dropDownService;
            Environment = environment;

            _enderService = tenderService;
        }

        [HttpGet]
        [Route("tender-create")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("tenderCategory")]
        public IActionResult ReturnTenderCategories() //It will be fired from Jquery ajax call
        {

            var jsonData = _dropDownService.tenderCategories();
            return Ok(
                          new
                          {
                              success = true,
                              message = "Successfully added",
                              payload = jsonData,
                          });
        }
        [HttpGet]
        [Route("tenderProcedure")]
        public IActionResult returnTenderProcedures() //It will be fired from Jquery ajax call
        {

            var jsonData = _dropDownService.tenderProcedureList();
            return Ok(
                          new
                          {
                              success = true,
                              message = "Successfully added",
                              payload = jsonData,
                          });
        }
        [HttpGet]
        [Route("tenderTechnique")]
        public IActionResult returnTenderProcurementTechnique() //It will be fired from Jquery ajax call
        {

            var jsonData = _dropDownService.cdfEvaluationmethods();
            return Ok(
                          new
                          {
                              success = true,
                              message = "Successfully added",
                              payload = jsonData,
                          });
        }

        [HttpGet]
        [Route("tenderProcPlan")]
        public IActionResult returnProcurementPlan() //It will be fired from Jquery ajax call
        {

            var jsonData = _dropDownService.cdfProcPlans();
            return Ok(
                          new
                          {
                              success = true,
                              message = "Successfully added",
                              payload = jsonData,
                          });
        }


        [Route("procItems")]
        [HttpGet]
        public IActionResult returnProcurementPlanItems(int ids)
        {

            var jsonData = _dropDownService.cdfPlanItems(ids);
            return Ok(
                          new
                          {
                              success = true,
                              message = "Successfully added",
                              payload = jsonData,
                          });

        }
        [HttpPost]
        [Route("create-tender")]
        public IActionResult createTender([FromBody] Tender request)
        {
  

            if (!ModelState.IsValid)
            {
                try
                {
                   int id= _enderService.CreateTender(request).Id;

                    HttpContext.Session.SetString("tenderID", id.ToString());


                    return Ok(
                                new
                                {
                                    success = false,
                                    message = "Successfully added",
                                    payload = id,
                                });
                }

                catch (Exception ex)
                {
                    return Ok(
                                 new
                                 {
                                     success = false,
                                     message = "Successfully added",
                                     payload = "",
                                 });
                }
            }
            else {
                return Ok(
                              new
                              {
                                  success = false,
                                  message = "Invalid",
                                  payload = "",
                              });
            }

        }
    }
    
}
