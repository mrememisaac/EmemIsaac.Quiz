using EmemIsaac.QuizManager.Application;
using EmemIsaac.QuizManager.Persistence;

namespace EmemIsaac.QuizManager.Api
{
    public static class StartupExtensions
    {
        public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddApplicationServices();
            builder.Services.AddPersistenceServices(builder.Configuration);

            builder.Services.AddControllers();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });
            builder.Services.AddSwagger();


            return builder.Build();
        }

        public static WebApplication ConfigurePipeline(this WebApplication app)
        {
            if(app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(config => {
                    config.SwaggerEndpoint("/swagger/v1/swagger.json", "QuizManager Quiz Management API");
                });
            }
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("Open");

            app.MapControllers();

            return app;
        }
    }
}
