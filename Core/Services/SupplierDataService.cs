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

        public SupplierDataService()
        {
            _context = new MyPayrollContext();
        }
        public List<CdfPlanItem> GetTenders()
        {
            try
            { 
                return _context.CdfPlanItems.ToList();
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }
    }
}
