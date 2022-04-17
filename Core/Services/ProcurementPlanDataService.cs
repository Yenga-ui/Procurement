using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Core.Services
{
    public class ProcurementPlanDataService : IProcurementPlanDataService
    {
        public Task<string> SaveAll(List<ProcurementPlanItem> procurementPlanItems)
        {
            throw new NotImplementedException();
        }
    }
}
