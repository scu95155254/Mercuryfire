using MercuryfireWebApplication.Models;

namespace MercuryfireWebApplication.Services
{
    public interface IMyofficeService
    {
        Task<bool> CreateMyofficeACPD(MyofficeACPDModel model);

        Task<MyofficeACPDModel> GetMyofficeACPDById(string id);

        Task<bool> UpdateMyofficeACPD(MyofficeACPDModel model);

        Task<bool> DeleteMyofficeACPD(string id);
    }
}
