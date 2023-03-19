using Cygnet.Banking.Domain.EntityFramework;
using Cygnet.Banking.Domain.IRepository;
using Cygnet.Banking.Domain.Repository;
using Cygnet.Banking.Services.Helpers;
using Cygnet.Banking.Services.Queries.AccountQueries;
using Microsoft.EntityFrameworkCore;

namespace Cygnet.Banking.Api
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddComponents(this IServiceCollection services,
            IConfiguration configuration)
        {
            services
                .AddServices(configuration);

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IBankingRepository, BankingRepository>();
            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<BankingContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), conf =>
                {
                }));

            return services;
        }
    }
}