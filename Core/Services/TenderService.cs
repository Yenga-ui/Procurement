using Core.Interfaces;
using Core.Models;
using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
   public class TenderService: ITenderService
    {

        private readonly MyPayrollContext db;



        public TenderService()
        {

            db=new MyPayrollContext();
        }

        public CdfTender CreateTender(Tender tender)
        {

            CdfTender cdfTender = new CdfTender();
            try
            {

           
            cdfTender.ClarificationDeadline = DateTime.Parse(tender.clarificationDeadline);
            cdfTender.TenderProcedure = tender.tenderProcedure;
            cdfTender.LongDescription = tender.longDescription;
            cdfTender.ShortDescription = tender.title;
            cdfTender.Category = tender.category;
            cdfTender.TenderProcurementTechnique = tender.procurementTechnique;
            cdfTender.BudgetId = 16;
            cdfTender.DueDate = DateTime.Parse(tender.submissionDeadline);
            cdfTender.InvitationDate=DateTime.Parse(tender.submissionDeadline);
            cdfTender.ContractNoticeDate = DateTime.Parse(tender.contractNoticeDate);
            
            }
            catch (Exception ex)
            {
                cdfTender.TenderProcedure = tender.tenderProcedure;
                cdfTender.LongDescription = tender.longDescription;
                cdfTender.ShortDescription = tender.title;

            }
            db.CdfTenders.Add(cdfTender);
            
            db.SaveChanges();
            cdfTender.TenderSerial = "Eps-" + cdfTender.Id;
            db.CdfTenders.Update(cdfTender);
            db.SaveChanges();
            return cdfTender;
        }

    }
}
