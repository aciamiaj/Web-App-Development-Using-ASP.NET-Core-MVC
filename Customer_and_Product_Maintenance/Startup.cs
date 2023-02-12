using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Lab3
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

#pragma warning disable MVC1005 // Cannot use UseMvc with Endpoint Routing
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "product",
                    template: "{controller=Product}/{action=Delete}/{productCode}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=List}/{id?}");
            });
#pragma warning restore MVC1005 // Cannot use UseMvc with Endpoint Routing
        }
    }
}