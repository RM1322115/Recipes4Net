using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Repositorio;
using Microsoft.EntityFrameworkCore;


namespace UIWeb
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

            //CONEXAO REFATORADA PARA CORE
            string StrConn = @"server=localhost;database=Recipes4Net;integrated security=true";
            services.AddDbContext<Recipes4NetDb>(optionsAction: builder => builder.UseSqlServer(StrConn));


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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });


            //var context = app.ApplicationServices.GetRequiredService<Recipes4NetDb>();
            //context.Database.Migrate();

            //var context = app.ApplicationServices.GetRequiredService<Recipes4NetDb>();
            //context.Database.EnsureCreated();

            //var context = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            //context.Database.EnsureCreated();

        }
    }
}
