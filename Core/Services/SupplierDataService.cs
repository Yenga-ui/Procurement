using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class SupplierDataService : ISupplierDataService
    {
        private readonly MyPayrollContext _context;

        public SupplierDataService(MyPayrollContext myPayrollContext)
        {
            _context = myPayrollContext;
        }
        public List<CdfPlanItem> GetTenders()
        {
            try
            {
                List<CdfPlanItem> tenders = _context.CdfPlanItems.ToList();

                return tenders;
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}
