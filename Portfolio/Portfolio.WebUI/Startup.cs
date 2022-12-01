using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Portfolio.Domain.Models.DataContext;
using Portfolio.Domain.Models.Entites.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Portfolio.WebUI
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
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(x => x.FullName
             .StartsWith("Portfolio."))
                .ToArray();


            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblies(assemblies);
            services.AddControllersWithViews();

            services.AddDbContext<PortfolioDbContext>(cfg =>
            {
                cfg.UseSqlServer(Configuration.GetConnectionString("cString"));
            });
            services.AddIdentity<AppUser, AppRole>(con =>
            {
                con.Password.RequiredLength = 8;
            }).AddEntityFrameworkStores<PortfolioDbContext>();

            //services.AddSingleton(typeof(IPipelineBehavior<,>), typeof(ValidateBehaviour<,>));
            services.AddMediatR(assemblies);

            services.AddAutoMapper(assemblies);

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(name: "defaultAdmin",
                areaName: "Admin",
                 pattern: "Admin/{controller=Admin}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(name: "default",
                        pattern: "{controller=Home}/{action=about}/{id?}");
            });
        }
    }
}
