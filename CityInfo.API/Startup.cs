﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace CityInfo.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .AddMvcOptions(o => o.OutputFormatters.Add(
                   new XmlDataContractSerializerOutputFormatter()));

                //.AddJsonOptions(o=> {
                //    if (o.SerializerSettings.ContractResolver != null)
                //    {
                //        var castedResolver = o.SerializerSettings.ContractResolver
                //            as DefaultContractResolver;
                //        castedResolver.NamingStrategy = null; //by default, the naming strategy is to start with lower case
                //    }
                //});
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
                app.UseExceptionHandler();
            }

            app.UseStatusCodePages();//in case of empty body, it displays the status code
            //!the middlewares order is very important

            app.UseMvc(); // add MVC middleware to the request pipeline

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
                //throw new Exception("buuu");
            });
        }
    }
}
