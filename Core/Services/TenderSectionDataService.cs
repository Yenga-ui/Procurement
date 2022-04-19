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
        public CdfTenderSection Save(CdfTenderSection tenderSection)
        {
            if(tenderSection == null) return null;

            var tender = new CdfTenderSection
            {
                Id = tenderSection.Id,
                Title = tenderSection.Title,
                Description = tenderSection.Description,
                SupportingDocumentation = tenderSection.SupportingDocumentation,
                TextResponse = (tenderSection.TextResponse)
            };

            try
            {
                db.CdfTenderSections.Add(tender);
                db.SaveChanges();
                return tenderSection;
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}
