using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using E_Procurement.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using E_Procurement.Services;
using System.IO;

namespace E_Procurement.Pages.SupplierTender
{
    public class CreateModel : PageModel
    {
        private readonly E_Procurement.Models.MyPayrollContext _context;

     
        private int tenderId;
        private string fullPath = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
       [Required]
        [Display(Name = "File")]
        public List<IFormFile> FormFiles { get; set; } // convert to list

        [BindProperty]
        public FileUpload fileUpload { get; set; }
        public string SuccessMessage { get; set; }

        [BindProperty]
        public string tenderID { get; set; }
        public CreateModel(E_Procurement.Models.MyPayrollContext context)
        {
            _context = context;
          
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            
            return Page();
        }

        [BindProperty]
        public CdfTender CdfTender { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CdfTender.Add(CdfTender);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        public IActionResult OnPostUpload(FileUpload fileUpload)
        {
            try {
                if (!Directory.Exists(fullPath))
                {
                    Directory.CreateDirectory(fullPath);
                }
                foreach (var aformFile in fileUpload.FormFiles)
                {
                    var formFile = aformFile;
                    if (formFile.Length > 0)
                    {
                        var filePath = Path.Combine(fullPath, formFile.FileName);
                        var fileName = formFile.FileName;
                        var fileExtension = Path.GetExtension(fileName);
                        String tender = fileUpload.tenderId;
                        String description = fileUpload.details;

                        int bidId = 0;

                        using(var context = new MyPayrollContext())
                        {
                            var bids = new CdfBid
                            {

                                SupplierId = Int32.Parse(HttpContext.Session.GetString("supplierID")),
                                TenderId = Int32.Parse(tender),
                                Details = fileUpload.details
                            };
                            context.CdfBid.Add(bids);
                            context.SaveChanges();

                            bidId = bids.Id;
                        };


                        var objFiles = new Document
                        {
                            Id = 0,
                            FileName = fileName,
                            FileType = fileExtension,
                            SupplierId = Int32.Parse(HttpContext.Session.GetString("supplierID")),
                            TenderId = Int32.Parse(tender),
                            BidId = bidId
                          


                        };

                        using (var target = new MemoryStream())
                        {
                            formFile.CopyTo(target);
                            objFiles.FileData = target.ToArray();
                        }
                        _context.Document.Add(objFiles);
                        _context.SaveChanges();
                    }
                }

                // Process uploaded files    
                // Don't rely on or trust the FileName property without validation.    
                ViewData["SuccessMessage"] = fileUpload.FormFiles.Count.ToString() + " files uploaded!!";
               
                return RedirectToPage("Index");
            }
            catch(Exception ex)
            {

                ViewData["SuccessMessage"] = "You have succesffully submitted your bid.";
                return Page();
            }
            }

     


    }
}
