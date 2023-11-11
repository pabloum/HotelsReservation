using HotelsReservation.Domain.Context;
using HotelsReservation.Repository.Contracts;
using HotelsReservation.Repository.UnitOfWork;
using HotelsReservation.Services.Contracts;
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
            services.RegisterAllDirectImplementations<IService>(ServiceLifetime.Scoped);
            services.RegisterAllDirectImplementations<IRepository>(ServiceLifetime.Scoped);
        }

        public static void InjectAdditionalInterfaces(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IRequestHandler, RequestHandler>();
        }

        public static void InjectDataBases(this IServiceCollection services, IConfiguration configuration)
        {

            if (configuration.GetValue<bool>("UseDataBase"))
            {
                services.AddDbContext<HotelsReservationsDbContext>(options =>
                    options.UseSqlServer(configuration.GetValue<string>("ConnectionStrings:HotelBookinDatabase")));
                using (var context = services.BuildServiceProvider().GetRequiredService<HotelsReservationsDbContext>())
                {
                    context.Database.EnsureCreated();
                }
            }
            else
            {
                services.AddDbContext<HotelsReservationsDbContext>(
                    opt => {
                        opt.UseInMemoryDatabase("Discoteque");
                    }
                );
            }
        }
    }
}

