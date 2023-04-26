using Microsoft.OpenApi.Models;

namespace EmemIsaac.QuizManager.Api
{
    public static class SwaggerServiceRegistration
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(config =>
             {
                 config.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Version = "v1",
                        Title = "QuizManager Quiz Management API"
                    });
             });
        }
    }
}
