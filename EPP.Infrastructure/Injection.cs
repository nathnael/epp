using EPP.Application.Contracts.Data;
using EPP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EPP.Infrastructure
{
    public static class Injectcion
    {
        public static IServiceCollection RegisterInfrastructerServices(
            this IServiceCollection service,
            IConfiguration configuration)
        {
            service.AddDbContext<EppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("EppDbConnection"));
            });

            service.AddScoped<IEppDbContext>(optiont => optiont.GetService<EppDbContext>());

            return service;
        }
    }
}
