using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
