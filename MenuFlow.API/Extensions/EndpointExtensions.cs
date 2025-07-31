using MenuFlow.API.Endpoints;

namespace MenuFlow.API.Extensions
{
    public static class EndpointExtensions
    {
        public static void MapEndpoints(this WebApplication app)
        {
            app.MapProductEndpoints();
        }
    }
}
