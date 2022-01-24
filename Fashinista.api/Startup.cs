using Fashinista.core.common;
using Fashinista.core.Repository;
using Fashinista.core.Services;
using Fashinista.infra.common;
using Fashinista.infra.Repository;
using Fashinista.infra.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fashinista.api
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
            
            services.AddScoped<IdbContext,dbContext>();

            services.AddScoped<IAgeRepository, AgeRepository>();
            services.AddScoped<IAgeServices,AgeServices>();

            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<ICategoryServices,CategoryServices>();

            services.AddScoped<IColorRepository, ColorRepository>();
            services.AddScoped<IColorServices, ColorServices>();

            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IMessageServices,MessageServices>();

            services.AddScoped<ITestimonialRepository, TestimonialRepository>();
            services.AddScoped<ITestimonialServices, TestimonialServices>();

            services.AddScoped<IOfferRepository,OfferRepository>();
            services.AddScoped<IOfferServices,OfferServices>();

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
