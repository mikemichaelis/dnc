using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using model;
using Newtonsoft.Json.Serialization;
using System.Configuration;
using System.IO;
using Breeze.AspNetCore;
using Breeze.Core;
using Microsoft.AspNetCore.Http;

namespace webapi
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
            var mvcBuilder = services.AddMvc();

            mvcBuilder.AddJsonOptions(opt => {
                var ss = JsonSerializationFns.UpdateWithDefaults(opt.SerializerSettings);
                var resolver = ss.ContractResolver;
                if (resolver != null) {
                var res = resolver as DefaultContractResolver;
                res.NamingStrategy = null;  // <<!-- this removes the camelcasing
                }
            });
            mvcBuilder.AddMvcOptions(o => { o.Filters.Add(new GlobalExceptionFilter()); });

            var connection = @"Data Source=.;Initial Catalog=dnc;User Id=sa;Password=asdfASDF!";
            services.AddDbContext<dncContext>(options => options.UseSqlServer(connection));            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
