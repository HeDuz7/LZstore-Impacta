﻿using LZStore.Models.Contexts;
using LZStore.Models.Interface.Context;
using LZStore.Models.Interface.Repositories;
using LZStore.Models.Interface.Services;
using LZStore.Models.Repositories;
using LZStore.Models.Services;
using Microsoft.EntityFrameworkCore;

namespace LZStore.Models.Configuration
{
    public class Configuration
    {

        public static void configureContextOld(IServiceCollection services)
        {
            services.AddSingleton<IContextData, ContextDataSqlServer>();
            services.AddSingleton<IConnectionManager, ConnectionManager>();
        }

        public static void configureContext(IServiceCollection services, IConfigurationManager config)
        {

            services.AddDbContext<LzStoreContext>(options => options.UseSqlServer(config.GetConnectionString("LzStoreConnection")));
        }

        public static void configureRepository(IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
        }

        public static void configureService(IServiceCollection services)
        {
            services.AddScoped<IClienteService, ClienteService>();
        }

        public static void configureValidation(IServiceCollection services)
        {
            //services.AddTransient<IValidator<ClienteDto>, ClienteValidator>();
        }

    }
}
