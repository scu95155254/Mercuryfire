
using Dapper;
using MercuryfireWebApplication.Models;
using System.Data;
using System.Data.SqlClient;

namespace MercuryfireWebApplication.Repositories
{
    public class MyofficeRepository : IMyofficeRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public MyofficeRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }


        public async Task<MyofficeACPDModel> GetMyofficeACPDById(string id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    // 開啟資料庫連接
                    //await connection.OpenAsync();

                    var result = await connection.QueryFirstOrDefaultAsync<MyofficeACPDModel>("GetMyofficeACPDByAcpdSid @AcpdSid", new { AcpdSid = id });

                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }

        public async Task<bool> CreateMyofficeACPD(MyofficeACPDModel model)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    // 定義參數
                    var parameters = new DynamicParameters();
                    parameters.Add("@AcpdCname", model.Acpd_Cname);
                    parameters.Add("@AcpdEname", model.Acpd_Ename);
                    parameters.Add("@AcpdSname", model.Acpd_Sname);
                    parameters.Add("@AcpdEmail", model.Acpd_Email);
                    parameters.Add("@AcpdStatus", model.Acpd_Status);
                    parameters.Add("@AcpdStop", model.Acpd_Stop);
                    parameters.Add("@AcpdStopMemo", model.Acpd_StopMemo); // NULL 如果沒有提供
                    parameters.Add("@AcpdLoginID", model.Acpd_LoginID);
                    parameters.Add("@AcpdLoginPW", model.Acpd_LoginPW);
                    parameters.Add("@AcpdMemo", model.Acpd_Memo); // NULL 如果沒有提供
                    parameters.Add("@AppdNowid", model.Appd_Nowid);
                    parameters.Add("@AcpdNowdatetime", model.Acpd_Nowdatetime);
                    parameters.Add("@AcpdUpddatetitme", model.Acpd_Upddatetitme); // NULL 如果沒有提供
                    parameters.Add("@AcpdUpdid", model.Acpd_Updid); // NULL 如果沒有提供
                    await connection.ExecuteAsync("AddMyofficeACPD", parameters, commandType: CommandType.StoredProcedure);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return false;
        }

        public Task<bool> DeleteMyofficeACPD(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateMyofficeACPD(MyofficeACPDModel model)
        {
            throw new NotImplementedException();
        }
    }
}
