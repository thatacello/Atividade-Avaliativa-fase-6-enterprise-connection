using System;
using System.Collections.Generic;
using System.Globalization;
using Atividade_Avaliativa_fase_6_front.Data;
using Atividade_Avaliativa_fase_6_front.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Atividade_Avaliativa_fase_6_front
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<Microsoft.AspNetCore.Identity.IdentityUser>(options => {
            }).AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();
            
            // --------- Services -----------
            services.AddScoped<AlugueCarroService>();
            services.AddScoped<CulturaService>();
            services.AddScoped<DicasUteisService>();
            services.AddScoped<EntretenimentoService>();
            services.AddScoped<GastronomiaService>();
            services.AddScoped<HistoriaService>();
            services.AddScoped<OndeHospedarService>();
            services.AddScoped<ParquesService>();
            services.AddScoped<VidaNoturnaService>();

            // popula base de dados 
            services.AddScoped<SeedingService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider, SeedingService seedingService)
        {
            // ------------ padrão Brasil ------------
            var ptBR = new CultureInfo("pt-BR");
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(ptBR),
                SupportedCultures = new List<CultureInfo>{ ptBR },
                SupportedUICultures = new List<CultureInfo>{ ptBR }
            };
            app.UseRequestLocalization(localizationOptions);
            // ------------------------------------------------

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                seedingService.Seed();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
            
            // migration
            serviceProvider.GetService<ApplicationDbContext>().Database.Migrate();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            // migration
            serviceProvider.GetService<ApplicationDbContext>().Database.Migrate();
        }
    }
}
