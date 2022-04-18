using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers
{
    public class ProcurementPlansController : Controller
    {
        private readonly ILogger<ProcurementPlansController> Logger;
        private readonly IWebHostEnvironment Environment;
        private readonly IExcelDataService ExcelDataService;
        private readonly IProcurementPlanDataService ProcurementPlanDataService;

        public ProcurementPlansController(IWebHostEnvironment environment,
            IExcelDataService excelDataService,
            IProcurementPlanDataService procurementPlanDataService,
            ILogger<ProcurementPlansController> logger)
        {
            Environment = environment;
            ExcelDataService = excelDataService;
            ProcurementPlanDataService = procurementPlanDataService;
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpPost]
        [Route("upload-plan")]
        public async Task<IActionResult> UploadPlanAsync(List<IFormFile> file)
        {
            var wwwPath = Environment.WebRootPath;
            var contentPath = Environment.ContentRootPath;

            var path = Path.Combine(Environment.WebRootPath, "Uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var savedProcurementPlanItems = new List<CdfPlanItem>();
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

                if (procurementPlanItems.Any())
                {
                    savedProcurementPlanItems = ProcurementPlanDataService.SaveAll(procurementPlanItems);
                }
            }

            return Ok(new { success = true, message = "File Uploaded Successfully", payload = savedProcurementPlanItems });

        }


        [HttpGet]
        [Route("procurement-plan")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("procurement-plan/create")]
        public ActionResult Create([FromBody] ProcurementPlanItem plan)
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

                if (savedPlanItem == null) throw new Exception("Failed To Save Plan Item");

                return Ok(
                        new
                        {
                            success = true,
                            message = "Successfully added",
                            payload = savedPlanItem,
                        });
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.StackTrace);
                
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
