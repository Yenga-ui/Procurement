using Core.Models;
using Core.ViewModels;

namespace Core.Interfaces
{
  public interface ITenderService
    {
        public CdfTender CreateTender(Tender tender);

    }
}
