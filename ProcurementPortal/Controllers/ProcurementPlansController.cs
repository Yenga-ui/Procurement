using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Portal.Controllers
{
    public class ProcurementPlansController : Controller
    {
        private readonly IWebHostEnvironment Environment;
<<<<<<< HEAD
        private readonly IExcelDataService   ExcelDataService;
        private MyPayrollContext db = new MyPayrollContext();
=======
        private readonly IExcelDataService ExcelDataService;
        private readonly IProcurementPlanDataService ProcurementPlanDataService;
>>>>>>> ca1be25c8ebce2a604b8281845fc58f5584e681f

        public ProcurementPlansController(IWebHostEnvironment _environment, IExcelDataService excelDataService,
            IProcurementPlanDataService procurementPlanDataService)
        {
            Environment = _environment;
            ExcelDataService = excelDataService;
            ProcurementPlanDataService = procurementPlanDataService;
        }

        public async Task<IActionResult> UploadPlanAsync(List<IFormFile> file)
        {
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            string path = Path.Combine(this.Environment.WebRootPath, "Uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string response = "";
            List<string> uploadedFiles = new List<string>();
            foreach (IFormFile postedFile in file)
            {
                string fileName = Path.GetFileName(postedFile.FileName);
                var uploadPath = Path.Combine(path, fileName);
                List<ProcurementPlanItem> procurementPlanItems = new List<ProcurementPlanItem>();
                using (FileStream stream = new FileStream(uploadPath, FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                    procurementPlanItems = await ExcelDataService.ParseExcelData(uploadPath);
                }

                if(procurementPlanItems != null && procurementPlanItems.Any())
                {
                   response = await ProcurementPlanDataService.SaveAll(procurementPlanItems);                    
                }                
            }

            return Ok(new { success = true, message = "File Uploaded Successfully", payload = response });

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProcurementPlanItem plan)
		{
            
            return Ok(plan);
		}




    }
}
