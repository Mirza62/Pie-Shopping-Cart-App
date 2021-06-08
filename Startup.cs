using Autofac;
using BethanysPie.Models;
using BethanysPie.RepositoryRegistrationModule;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPie
{
    public class Startup
    {

        public IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Register Framework Services
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"))
            );

            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>();


#region builder
            //services.AddScoped<IPieRepository, PieRepository>();
            //services.AddScoped<ICategoryRepository, CategoryRepository>();

            //services.AddScoped<IOrderRepository, OrderRepository>();
#endregion

            //services.AddTransient();
            //Services.AddSingleton();

            //Cookie
            services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
            services.AddHttpContextAccessor();
            services.AddSession();

            services.AddControllersWithViews();
            services.AddRazorPages();
            //services.AddMvc();

            //Register our own Services
            //services.AddScoped<IPieRepository, MockPieRepository>();
        }


        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<RegistrationModule>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "defaults",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
