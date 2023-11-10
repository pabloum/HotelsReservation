using System;
using Microsoft.EntityFrameworkCore;

namespace HotelsReservation.Api.Installers
{
    public static class BusinessServiceInstaller
    {
        public static void AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConfiguration>(configuration);
            services.InjectDataBases(configuration);
            services.InjectAdditionalInterfaces();
        }

        public static void InjectAdditionalInterfaces(this IServiceCollection services)
        {
            //services.AddScoped<IAuthentication, Authentication>();
            //services.AddScoped<IRequestHandler, RequestHandler>();
        }

        public static void InjectDataBases(this IServiceCollection services, IConfiguration configuration)
        {
            //services.RegisterAllDirectImplementations<IService>(ServiceLifetime.Scoped);

            //services.AddDbContext<HotelsDbContext>(options =>
            //    options.UseSqlServer(configuration.GetValue<string>("ConnectionStrings:HotelBookinDatabase")));

            //if (configuration.GetValue<bool>("UseDataBase"))
            //{
            //    using (var context = services.BuildServiceProvider().GetRequiredService<HotelsDbContext>())
            //    {
            //        context.Database.EnsureCreated();
            //    }
            //}
        }
    }
}

