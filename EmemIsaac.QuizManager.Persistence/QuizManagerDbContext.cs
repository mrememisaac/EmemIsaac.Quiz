using EmemIsaac.QuizManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmemIsaac.QuizManager.Persistence
{
    public class QuizManagerDbContext : DbContext
    {
        public QuizManagerDbContext(DbContextOptions<QuizManagerDbContext> options): base(options) { }

        public DbSet<Quiz> Quizzes { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Option> Options { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(QuizManagerDbContext).Assembly);
        }
    }
}
