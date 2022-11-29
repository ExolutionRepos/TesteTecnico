using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TesteTecnico.Api.Configuration;

namespace TesteTecnico.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        
        // CONFIGURATION SERVICES
        public void ConfigureServices(IServiceCollection services)
        {
            // MAPPER
            services.AddAutoMapper(typeof(Startup));

            // DependencyInjectionConfig
            services.ResolveDependencies();

            // CONFIG. MVC
            services.AddMvc()
               .SetCompatibilityVersion(CompatibilityVersion.Latest);

            // CONFIGURE API
            services.AddApiConfig();
        }

        // CONFIGURATION
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // ENV
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SwaggerSetupExample v1"));
                app.UseDeveloperExceptionPage();
            }


            // CONFIG. ROUTING
            app.UseApiConfig(env);
        }
    }
}
