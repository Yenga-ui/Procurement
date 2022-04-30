using Core.Models;
namespace Core.Interfaces
{
   public interface IDropDownService
    {
        List<CdfTenderProcedure> tenderProcedureList();
        List<CdfTenderCategory> tenderCategories();
        List<CdfEvaluationmethod> cdfEvaluationmethods();
        List<CdfPlanItem> cdfPlanItems(int procPlanId);

        List<CdfProcPlan> cdfProcPlans();

    }
}
