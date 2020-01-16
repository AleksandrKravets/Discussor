using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Discussor.Core.Application;
using Discussor.Infrastructure;
using Discussor.WebUI.Infrastructure.Filters;

namespace Discussor.WebUI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication();
            services.AddInfrastructure(Configuration);
            services.AddControllersWithViews();
            services.AddCloudscribePagination();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            } else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();    

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();

                endpoints.MapAreaControllerRoute(
                    name: null,
                    areaName: "Admin",
                    pattern: "Admin/{controller=Admin}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    name: null,
                    areaName: "Account",
                    pattern: "Account/{controller=Account}/{action=Login}");

                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "Post/{postId}",
                    defaults: new { controller = "Post", action = "Post" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "/",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
