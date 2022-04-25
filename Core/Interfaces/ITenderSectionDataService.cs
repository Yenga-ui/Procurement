using Core.Models;

namespace Core.Interfaces
{
    public interface ITenderSectionDataService
    {
        CdfTenderSection Save(CdfTenderSection tenderSection);

        CdfTenderSectionSub SaveSub(CdfTenderSectionSub sub);

    }
}
