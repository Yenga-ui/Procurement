using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Portal.Controllers
{
    public class ProcurementPlansController : Controller
    {
        private readonly IWebHostEnvironment Environment;
        private readonly IExcelDataService   ExcelDataService;

        public ProcurementPlansController(IWebHostEnvironment _environment, IExcelDataService excelDataService)
        {
            Environment = _environment;
            ExcelDataService = excelDataService;
        }

        public IActionResult UploadPlan(List<IFormFile> file)
        {

            /*HttpFileCollection MyFileCollection;
        HttpPostedFile MyFile;
        int FileLen;
        System.IO.Stream MyStream;

        MyFileCollection = Request.Files;
        MyFile = MyFileCollection[0];

        FileLen = MyFile.ContentLength;
        //byte[] input = new byte[FileLen];*/
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            string path = Path.Combine(this.Environment.WebRootPath, "Uploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            List<string> uploadedFiles = new List<string>();
            foreach (IFormFile postedFile in file)
            {
                string fileName = Path.GetFileName(postedFile.FileName);
                var uploadPath = Path.Combine(path, fileName);
                using (FileStream stream = new FileStream(uploadPath, FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                    ExcelDataService.ParseExcelData(uploadPath);
                }
            }
            return Ok(new {success = true, message = "File Uploaded Successfully" });
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ProcurementPlanCreate()
        {
            return View();
        }


    }
}
