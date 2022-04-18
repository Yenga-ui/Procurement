using Core.Interfaces;
using Core.Models;
using Core.Utils;

namespace Core.Services
{
    public class ProcurementPlanDataService : IProcurementPlanDataService
    {
        private readonly MyPayrollContext db;
        public ProcurementPlanDataService()
        {
            db = new MyPayrollContext();
        }
        public List<CdfPlanItem> SaveAll(List<CdfPlanItem> procurementPlanItems)
        {
            try
            {
                db.CdfPlanItems.AddRange(procurementPlanItems);
                db.SaveChanges();
                return procurementPlanItems;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }

        }
        
        CdfPlanItem IProcurementPlanDataService.Save(ProcurementPlanItem procurementPlanItems)
        {
            if(procurementPlanItems == null) return null;

            var planItem = new CdfPlanItem
            {
                Class = procurementPlanItems.Class,
                Unspsc = procurementPlanItems.UNSPSC,
                Description = procurementPlanItems.Description,
                RefNo = procurementPlanItems.Ref_No,
                ProjectCode = procurementPlanItems.Project_Code ?? "",
                Unitofmeasure = procurementPlanItems.Unit_of_Measure ?? "",
                Quantity = Convert.ToInt32(procurementPlanItems.Quantity),
                SourceOfFunds = procurementPlanItems.Source_of_Funds,
                Prequalification = procurementPlanItems.Prequalification,
                ProcurementMethod = procurementPlanItems.Procurement_Method,
                Publication = Util.ToDateTime(procurementPlanItems.Publication).ToString(),
                Award = Util.ToDateTime(procurementPlanItems.Award).ToString(),
                Start = Util.ToDateTime(procurementPlanItems.Start),
                Comments = procurementPlanItems.Comments ?? "",
                Typeofentry = procurementPlanItems.Type_of_Entry ?? ""
            };

            Console.Write(planItem);
            db.CdfPlanItems.Add(planItem);
            db.SaveChanges();
            return planItem;
        }
       
        public List<CdfPlanItem> SaveAll(List<ProcurementPlanItem> procurementPlanItems )
        {

            var cdfPlanItems = procurementPlanItems.Select(item => new CdfPlanItem
                {
                    Class = item.Class,
                    Unspsc = item.UNSPSC,
                    Description = item.Description,
                    RefNo = item.Ref_No,
                    ProjectCode = item.Project_Code ?? "",
                    Unitofmeasure = item.Unit_of_Measure ?? "",
                    Quantity = Convert.ToInt32(item.Quantity),
                    SourceOfFunds = item.Source_of_Funds,
                    Prequalification = item.Prequalification,
                    ProcurementMethod = item.Procurement_Method,                    
                    Publication = item.Publication,
                    Award = item.Award,
                    Start = Util.ToDateTime(item.Start),
                    Comments = item.Comments ?? "",
                    Typeofentry = item.Type_of_Entry ?? ""
            })
                .ToList();
     

            db.CdfPlanItems.AddRange(cdfPlanItems);
            db.SaveChanges();
            
           return cdfPlanItems;
        }
    }
}
