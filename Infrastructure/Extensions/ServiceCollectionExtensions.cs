using Application.Services;
using Core.Interfaces;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUserInterfaces, UserRepository>();
            services.AddScoped<IMoneyTransferInterfaces, MoneyTransferRepository>();
            services.AddScoped<UserServices>();
            services.AddScoped<ExchangeRateService>();
            services.AddScoped<MoneyTransferServices>();
            return services;
        }
    }
}
