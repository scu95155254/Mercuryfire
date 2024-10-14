using MercuryfireWebApplication.Models;

namespace MercuryfireWebApplication.Repositories
{
    public interface IMyofficeRepository
    {
        Task<bool> CreateMyofficeACPD(MyofficeACPDModel model);

        Task<MyofficeACPDModel> GetMyofficeACPDById(string id);

        Task<bool> UpdateMyofficeACPD(MyofficeACPDModel model);

        Task<bool> DeleteMyofficeACPD(string id);
    }
}
