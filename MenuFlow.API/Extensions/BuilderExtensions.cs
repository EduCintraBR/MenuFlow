using MenuFlow.Application;
using MenuFlow.Infrastructure.Persistence;
using Microsoft.OpenApi.Models;

namespace MenuFlow.API.Extensions
{
    public static class BuilderExtensions
    {
        public static WebApplicationBuilder AddArchitectures(this WebApplicationBuilder builder)
        {

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MenuFlow.Api", Version = "v1" });
            });

            return builder;
        }

        public static WebApplicationBuilder AddDependencies(this WebApplicationBuilder builder)
        {
            builder.Services.AddApplication();
            builder.Services.AddInfrastructure(builder.Configuration);

            return builder;
        }
    }
}
