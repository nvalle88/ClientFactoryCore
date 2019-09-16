using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientFactoryCore.Data;
using ClientFactoryCore.HTTPClient;
using GeoCode.Util;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ClientFactoryCore
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

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddDbContext<SaludsaContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddHealthChecks()
                .AddCheck("MyDatabase", new SqlConnectionHealthCheck(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<TimingHandler>();

            services.Replace(ServiceDescriptor.Singleton<IHttpMessageHandlerBuilderFilter, CustomLoggingFilter>());

            services.AddHttpClient<IPaisServicio, PaisServicio>(x => x.BaseAddress = new Uri("https://restcountries.eu/"))
                .AddHttpMessageHandler<TimingHandler>()
                .SetHandlerLifetime(TimeSpan.FromSeconds(10))
                .AddPolicyHandler(PolicyHttpClient.GetRetryPolicy())
                .AddPolicyHandler(PolicyHttpClient.GetCircuitBreakerPolicy());
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

            app.UseHealthChecks("/hc");
        }
    }
}
