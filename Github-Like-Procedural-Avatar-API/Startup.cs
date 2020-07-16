using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Github_Like_Procedural_Avatar;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using static Github_Like_Procedural_Avatar.Generator;

namespace Github_Like_Procedural_Avatar_API
{
    public class Startup
    {
        public readonly static Generator Generator = new Generator(10, 10); // initiating the matrix with 10 x 10 positions
        // we want to make it readonly because we will use the same object for the entire runtime
        // static because we do not need more than one generator object per run
        // it's public because it will be accessed outside of Startup class

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
