using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodItems.API.Models;
using FoodItems.API.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace FoodItems.API
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
            services.AddControllers();


            services.Configure<DatabaseSettings>(
         Configuration.GetSection(nameof(DatabaseSettings)));

            services.AddSingleton<DatabaseSettings>(sp =>
        sp.GetRequiredService<IOptions<DatabaseSettings>>().Value);


            services.AddSingleton<IFoodItemsRepository, FoodItemsRepository>();


            //services.AddSwaggerGen(options =>
            //{
            //    options.DescribeAllEnumsAsStrings();
            //    options.SwaggerDoc("v1", new OpenApiInfo { Title = "eShopOnContainers - Catalog HTTP API", Version = "v1", Description = "The Catalog Microservice HTTP API. This is a Data-Driven/CRUD microservice sample" });
            //});

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.UseSwagger();
            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Identity V1");
            //});

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
