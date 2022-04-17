using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Portal.Controllers
{
    public class ProcurementPlansController : Controller
    {
        private readonly IWebHostEnvironment Environment;
        private readonly IExcelDataService ExcelDataService;
        private readonly IProcurementPlanDataService ProcurementPlanDataService;

        public ProcurementPlansController(IWebHostEnvironment _environment, IExcelDataService excelDataService,
            IProcurementPlanDataService procurementPlanDataService)
        {
            Environment = _environment;
            ExcelDataService = excelDataService;
            ProcurementPlanDataService = procurementPlanDataService;
        }

        [HttpPost]
        [Route("upload-plan")]
        public async Task<IActionResult> UploadPlanAsync(List<IFormFile> file)
        {
            var wwwPath = this.Environment.WebRootPath;
            var contentPath = this.Environment.ContentRootPath;

            var path = Path.Combine(this.Environment.WebRootPath, "Uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var response = "";
            
            foreach (var postedFile in file)
            {
                var fileName = Path.GetFileName(postedFile.FileName);
                var uploadPath = Path.Combine(path, fileName);
                List<ProcurementPlanItem> procurementPlanItems;
                await using (var stream = new FileStream(uploadPath, FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                    procurementPlanItems = await ExcelDataService.ParseExcelData(uploadPath);
                }

                if(procurementPlanItems.Any())
                {
                   response = await ProcurementPlanDataService.SaveAll(procurementPlanItems);                    
                }                
            }

            return Ok(new { success = true, message = "File Uploaded Successfully", payload = response });

        }
     

        [HttpGet]
        [Route("procurement-plan")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProcurementPlanItem plan)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Ok(
                        new
                        {
                            success = false,
                            message = "Validation Failed"
                        });
                }

               var savedPlanItem = ProcurementPlanDataService.Save(plan);

                return Ok(
                        new
                        {
                            success = true,
                            message = "Successfully added",
                            payload = savedPlanItem,
                        });
            }
            catch (Exception)
            {
                //log exception
                return Ok(
                        new
                        {
                            success = false,
                            message = "message"
                        }); 
            }
        }


    }
}
