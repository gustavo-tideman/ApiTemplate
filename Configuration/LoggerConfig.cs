using ApiTemplate.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace ApiTemplate.Configuration
{
    public static class LoggerConfig
    {
        public static IServiceCollection AddLoggingConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHealthChecks()
                .AddCheck("Tabelas", new SqlServerHealthCheck(configuration.GetConnectionString("DefaultConnection")))

                .AddSqlServer(configuration.GetConnectionString("DefaultConnection"), name: "BancoSQL");

                //Quando se tem um Banco de dados MongoDB
                //.AddMongoDb(mongodbConnectionString: configuration.GetConnectionString("DefaultConnectionMongo"), name: "MongoDB", failureStatus: HealthStatus.Unhealthy);                

            return services;
        }

        public static IApplicationBuilder UseLoggingConfiguration(this IApplicationBuilder app)
        {
            return app;
        }
    }
}