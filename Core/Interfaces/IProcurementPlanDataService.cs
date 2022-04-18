﻿using Core.Models;

namespace Core.Interfaces
{
    public interface IProcurementPlanDataService
    {
        List<CdfPlanItem> SaveAll(List<CdfPlanItem> procurementPlanItems);
        CdfPlanItem Save(ProcurementPlanItem procurementPlanItems);
        List<CdfPlanItem> SaveAll(List<ProcurementPlanItem> procurementPlanItems);
         int createProcPlan(CdfProcPlan cdfProcPlan);

        List<CdfPlanItem> getAllPlanItems(int id);
    }
}
