using EPP.Application.Contracts.Logics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EPP.Application
{
    public static class Injectcion
    {
        public static IServiceCollection RegisterApplicationServices(
            this IServiceCollection service,
            IConfiguration configuration)
        {
            service.AddScoped<IExcellerLogic, ExcellerLogic>();
            return service;
        }
    }
}
