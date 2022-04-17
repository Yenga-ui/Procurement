﻿using Core.Interfaces;
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

                if (procurementPlanItems != null && procurementPlanItems.Any())
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
