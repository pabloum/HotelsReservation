using System;
using HotelsReservation.Api.Installers;
using HotelsReservation.Api.Middleware;

namespace HotelsReservation.Api
{
	public class StartUp
	{
		public IConfiguration configRoot { get; }

		public StartUp(IConfiguration configuration)
		{
			configRoot = configuration;
		}

		public void ConfigureServices(IServiceCollection services)
		{
            services.AddControllers();

            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Hotels Reservations API", Version = "v1" });
            });

            services.AddSignalR();
            services.AddHttpClient();
            services.AddBusinessServices(configRoot);
            services.InjectAdditionalInterfaces();
        }

		public void Configure(WebApplication app, IWebHostEnvironment env)
		{
            // Configure the HTTP request pipeline
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            else
            {
                app.UseHttpsRedirection();
            }

            app.UseCors("AllowSpecificOrigins");

            app.UseRouting();
            app.UseMiddleware<ExceptionHandlingMiddleware>();

            //app.UseAuthentication();
            //app.UseAuthorization();

            app.MapControllers();
            //app.UseEndpoints(e =>
            //{
            //    e.MapHub<ChatHub.ChatHub>("/chatroom");
            //    e.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller}");
            //});

            app.Run();
        }
	}
}

