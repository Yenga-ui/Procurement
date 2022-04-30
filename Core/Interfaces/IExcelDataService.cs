using Core.Models;

namespace Core.Interfaces
{
    public interface IExcelDataService
    {
        Task<List<ProcurementPlanItem>> ParseExcelData(string uploadPath);
    }
}
