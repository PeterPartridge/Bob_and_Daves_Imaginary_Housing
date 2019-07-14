
using API.DataLayer;
using API.DataLayer.Interface;
using API.SharedObjects.ConcreteClasses;
using API.SharedObjects.Interfaces;
using API.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace APILibrary
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSingleton(Configuration.GetSection("CSVData").Get<CSVAppSettings>());
            //services.AddSingleton(Configuration.GetSection("SQLData").Get<SQLAppSettings>());
            services.AddScoped<IBaseProperty, BaseProperty>();
            services.AddScoped<IFindAddress, CSVService>();
            services.AddScoped<IFindProperty, CSVService>();
            //adding app details through dependancy injection           
            var SQLConnection = @"Server=localhost\SQLEXPRESS02;Database=BDIHousing;Trusted_Connection=True;";
            services.AddDbContext<BDIHousingContext>
                (options =>
                {
                    options.UseSqlServer(SQLConnection);
                });
            services.AddScoped<IBDIHousingContext, BDIHousingContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
