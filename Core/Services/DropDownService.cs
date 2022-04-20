using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{

    public class DropDownService: IDropDownService
    {
        private readonly MyPayrollContext db;

        public DropDownService()
        {

            db= new MyPayrollContext();
        }

        public List<CdfTenderProcedure> tenderProcedureList()
        {


            return db.CdfTenderProcedures.ToList();
        } 

        public List<CdfTenderCategory> tenderCategories()
        {
            return db.CdfTenderCategories.ToList();
        }
        
        public List<CdfTenderSection> tenderSections()
        {
            return db.CdfTenderSections.ToList();
        }

        public List<CdfEvaluationmethod> cdfEvaluationmethods()
        {
            return db.CdfEvaluationmethods.ToList();
        }

        public List<CdfProcPlan> procPlans(int id)
        {

            return db.CdfProcPlans.ToList().Where(p => p.Id == id).ToList();
        }

        public List<CdfPlanItem> cdfPlanItems(int procPlanId)
        {
            try
            {
                return db.CdfPlanItems.ToList().Where((p) => p.ProcPlanId == procPlanId).ToList();
            }
            catch(Exception ex)
            {
                return null;
            }
        }

       

        List<CdfProcPlan> IDropDownService.cdfProcPlans()
        {
            return db.CdfProcPlans.ToList();
        }
    }
}
