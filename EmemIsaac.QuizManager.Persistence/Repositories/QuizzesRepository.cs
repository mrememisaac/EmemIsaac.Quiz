using EmemIsaac.QuizManager.Application.Contracts.Persistence;
using EmemIsaac.QuizManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmemIsaac.QuizManager.Persistence.Repositories
{
    public class QuizzesRepository : BaseRepository<Quiz, Guid>, IQuizzesRepository
    {
        public QuizzesRepository(QuizManagerDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IReadOnlyList<Quiz>> GetQuizzessByCreatorAsync(string userId)
        {
            return await _dbContext.Quizzes.Where(q => q.CreatedBy == userId).ToListAsync();
        }
    }
}
