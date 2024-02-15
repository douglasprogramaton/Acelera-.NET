using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Livraria.Infrastructure.Data;

namespace Livraria.API
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = "server=zapcidade.app;port=3306;database=livraria;uid=livraria;password=aceleranet";

            services.AddDbContext<LivrariaContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
            );

        }
    }
}
