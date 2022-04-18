using Core.Interfaces;
using Core.Models;
using Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Portal.Controllers
{
    public class ProcurementPlansController : Controller
    {
        private readonly IWebHostEnvironment Environment;
        private readonly IExcelDataService ExcelDataService;
        private readonly IProcurementPlanDataService ProcurementPlanDataService;

        public ProcurementPlansController(IWebHostEnvironment environment, IExcelDataService excelDataService,
            IProcurementPlanDataService procurementPlanDataService)
        {
            Environment = environment;
            ExcelDataService = excelDataService;
            ProcurementPlanDataService = procurementPlanDataService;
        }

        [HttpGet]
        [Route("PlanItems")]
        public List<Core.Models.CdfPlanItem> procItems()
        {
            try
            {

                List<CdfPlanItem> procItems=ProcurementPlanDataService.getAllPlanItems(Int32.Parse(HttpContext.Session.GetString("ProcID")));
                return procItems;
            }
            catch(Exception ex)
            {

                return null;
            }


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
                List<Core.Models.ProcurementPlanItem> procurementPlanItems;
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

        [Route("ProcHeader")]
        [HttpPost]
        public IActionResult procHeader([FromBody] PlanHeader request)
        {
            if (!ModelState.IsValid) return Ok(
                 new { success = false, message = "Validatio Failed" });

            CdfProcPlan cdfProcPlan = new CdfProcPlan();
            cdfProcPlan.Year = request.year;
            cdfProcPlan.Comments = request.description;

            int Id = ProcurementPlanDataService.createProcPlan(cdfProcPlan);

            HttpContext.Session.SetString("ProcID", Id.ToString());
            return Ok(
                         new
                         {
                             success = true,
                             message = "Successfully added",
                             payload = Id,
                         });
        }

        [HttpPost]
        [Route("procurement-plan/create")]
        public ActionResult Create([FromBody] Core.Models.ProcurementPlanItem plan)
        {
            try
            {
                ModelState.Remove("procPlanId");
                if (!ModelState.IsValid)
                {
                    return Ok(
                        new
                        {
                            success = false,
                            message = "Validation Failed"
                        });
                }
                plan.procPlanId = HttpContext.Session.GetString("ProcID");
                var savedPlanItem = ProcurementPlanDataService.Save(plan);

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
                Console.Write(ex.Message);
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
