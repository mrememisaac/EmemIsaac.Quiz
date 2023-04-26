using EmemIsaac.QuizManager.Application.Contracts.Persistence;
using EmemIsaac.QuizManager.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmemIsaac.QuizManager.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<QuizManagerDbContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString(Common.Constants.ConnectionString)));
            
            services.AddScoped(typeof(IAsyncRepository<,>), typeof(BaseRepository<,>));
            services.AddScoped<IQuizzesRepository, QuizzesRepository>();

            return services;
        }
    }
}
