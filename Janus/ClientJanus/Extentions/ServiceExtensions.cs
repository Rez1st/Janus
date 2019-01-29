using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Model.Janus.Settings;
using RepositoryJanus;

namespace ClientJanus.Extentions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionStrings:SqlConnectionString"];

            services.AddDbContext<JanusContext>(options => options.UseSqlServer(connectionString));
        }

        public static void ConfigureSettings(this IServiceCollection services, IConfiguration config)
        {
            services.AddOptions();

            services.Configure<TestSettings>(config.GetSection("TestSettings"));
        }

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("janus", new OpenApiInfo {Title = "Any API yo want", Version = "v1"});
            });
            services.ConfigureSwaggerGen(x =>
            {
                x.DescribeAllEnumsAsStrings();
                x.IncludeXmlComments(AppContext.BaseDirectory + "Janus.Api.xml");
                x.IgnoreObsoleteActions();
                x.IgnoreObsoleteProperties();
            });
        }
    }
}