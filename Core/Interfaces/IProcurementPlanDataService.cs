using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProcurementPlanDataService
    {
        Task<string> SaveAll(List<ProcurementPlanItem> procurementPlanItems);
    }
}
