using CAPA_NEGOCIOS;
using CAPA_NEGOCIOS.InterfacesMaestrosDetalles;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAPA_UI
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

            services.AddRazorPages();
            services.AddControllers();
            services.AddControllers().AddNewtonsoftJson();
            services.AddScoped<ICompraMaestroDetalle, CompraMaestroDetalle>();
            services.AddScoped<IVentaMaestroDetalle, VentaMaestroDetalle>();
            services.AddScoped<IDevolucionMaestroDetalle, DevolucionMaestroDetalle>();
            services.AddSession(Option =>
            {
                Option.IdleTimeout = TimeSpan.FromSeconds(10);
                Option.Cookie.HttpOnly = true;
                Option.Cookie.IsEssential= true;
            });

            services.AddSession();
            services.AddMvc();

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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });
        }
    }
}
