
using MercuryfireWebApplication.Models;
using MercuryfireWebApplication.Repositories;

namespace MercuryfireWebApplication.Services
{
    public class MyofficeService : IMyofficeService
    {
        private readonly IMyofficeRepository _myofficeRepository;

        public MyofficeService(IMyofficeRepository myofficeRepository) 
        {
            _myofficeRepository = myofficeRepository;
        }

        public Task<bool> CreateMyofficeACPD(MyofficeACPDModel model)
        {
            return _myofficeRepository.CreateMyofficeACPD(model);
        }

        public Task<MyofficeACPDModel> GetMyofficeACPDById(string id)
        {
            return _myofficeRepository.GetMyofficeACPDById(id);
        }

        public Task<bool> UpdateMyofficeACPD(MyofficeACPDModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteMyofficeACPD(string id)
        {
            throw new NotImplementedException();
        }
    }
}
