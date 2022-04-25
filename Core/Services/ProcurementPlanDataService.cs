using Core.Interfaces;
using Core.Models;
using Core.Utils;

namespace Core.Services
{
    public class ProcurementPlanDataService : IProcurementPlanDataService
    {
        private readonly MyPayrollContext db;
        public ProcurementPlanDataService(MyPayrollContext myPayrollContext)
        {
            db = myPayrollContext;
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
        int IProcurementPlanDataService.saveTender(CdfTender cdfTender)
        {
            try
            {
                db.CdfTenders.Add(cdfTender);
                return cdfTender.Id;
            }
            catch(Exception ex)
            {

                return 0;
            }
        }
        List<CdfPlanItem> IProcurementPlanDataService.getAllPlanItems(int id)
        {
            try
            {
                List<CdfPlanItem> planItems = db.CdfPlanItems.ToList().Where(x => x.ProcPlanId == id).ToList();
                return planItems;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        CdfPlanItem IProcurementPlanDataService.Save(ProcurementPlanItem procurementPlanItems)
        {
            if(procurementPlanItems == null) return null;

            var planItem = new CdfPlanItem
            {
                Class = procurementPlanItems.Class,
                ProcPlanId=Int32.Parse(procurementPlanItems.procPlanId),
                Unspsc = procurementPlanItems.UNSPSC,
                Description = procurementPlanItems.Description,
                RefNo = procurementPlanItems.Ref_No,
                ProjectCode = procurementPlanItems.Project_Code ?? "",
                UnitOfMeasure = procurementPlanItems.Unit_of_Measure ?? "",
                Quantity = procurementPlanItems.Quantity == "" || procurementPlanItems.Quantity == null ? 0 : Convert.ToInt32(procurementPlanItems.Quantity),
                SourceOfFunds = procurementPlanItems.Source_of_Funds,
                Prequalification = procurementPlanItems.Prequalification,
                ProcurementMethod = procurementPlanItems.Procurement_Method,

                Budget = Decimal.Parse(procurementPlanItems.budget),
                Publication = Util.ToDateTime(procurementPlanItems.Publication).ToString(),
                Award = Util.ToDateTime(procurementPlanItems.Award).ToString(),


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
                    UnitOfMeasure = item.Unit_of_Measure ?? "",
                    Quantity = item.Quantity == "" || item.Quantity == null ? 0: Convert.ToInt32(item.Quantity),
                    SourceOfFunds = item.Source_of_Funds,
                    Prequalification = item.Prequalification,
                    ProcurementMethod = item.Procurement_Method,                    
                    Publication = Util.ToDateTime(item.Publication),
                    Award = Util.ToDateTime(item.Award),
                    Start = Util.ToDateTime(item.Start),
                    Comments = item.Comments ?? "",
                    TypeOfEntry = item.Type_of_Entry ?? ""
            })
                .ToList();
     

            db.CdfPlanItems.AddRange(cdfPlanItems);
            db.SaveChanges();
            
           return cdfPlanItems;
        }

        public int createProcPlan(CdfProcPlan cdfProcPlan)
        {

            try
            {
                db.CdfProcPlans.Add(cdfProcPlan);
                db.SaveChanges();
                return cdfProcPlan.Id;

            }
            catch (Exception ex)
            {

                return 0;
            }
        }
    }
}
