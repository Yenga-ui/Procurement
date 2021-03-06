using Core.Interfaces;
using Core.Models;

namespace Core.Services
{
    public class TenderSectionDataService : ITenderSectionDataService
    {
        private readonly MyPayrollContext db;

        public TenderSectionDataService(MyPayrollContext payrollContext)
        {
            db = payrollContext;
        }

        CdfTenderSectionSub ITenderSectionDataService.SaveSub(CdfTenderSectionSub sub)
        {

                db.CdfTenderSectionSubs.Add(sub);
                db.SaveChanges();
                return sub;

           
            

        }
        CdfTenderSection ITenderSectionDataService.Save(CdfTenderSection tenderSection)
        {

         
                if (tenderSection == null) return null;

                var tender = new CdfTenderSection
                {
                    Id = tenderSection.Id,
                    Title = tenderSection.Title,
                    TenderId = tenderSection.TenderId,
                    Description = tenderSection.Description,
                    SupportingDocumentation = tenderSection.SupportingDocumentation,
                    TextResponse = (tenderSection.TextResponse),
                    
                };


                db.CdfTenderSections.Add(tender);
                db.SaveChanges();
                return tenderSection;
            
            }
           
        
    }
}
