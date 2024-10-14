using MercuryfireWebApplication.Repositories;
using MercuryfireWebApplication.Services;

namespace MercuryfireWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddScoped<IMyofficeService, MyofficeService>();
            builder.Services.AddScoped<IMyofficeRepository, MyofficeRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
