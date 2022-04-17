using Core.Models;

namespace Core.Interfaces
{
    public interface IProcurementPlanDataService
    {
        List<CdfPlanItem> SaveAll(List<CdfPlanItem> procurementPlanItems);
        CdfPlanItem Save(ProcurementPlanItem procurementPlanItems);
        List<CdfPlanItem> SaveAll(List<ProcurementPlanItem> procurementPlanItems);
    }
}
