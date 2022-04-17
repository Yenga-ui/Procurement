using Core.Models;

namespace Core.Interfaces
{
    public interface IProcurementPlanDataService
    {
        List<CdfPlanItem> SaveAll(List<CdfPlanItem> procurementPlanItems);
        CdfPlanItem Save(ProcurementPlanItem procurementPlanItems);
        Task<string> SaveAll(List<ProcurementPlanItem> procurementPlanItems);
    }
}
