using EmemIsaac.QuizManager.Domain.Entities;

namespace EmemIsaac.QuizManager.Application.Contracts.Persistence
{
    public interface IQuizzesRepository : IAsyncRepository<Domain.Entities.Quiz, Guid>
    {
        Task<IReadOnlyList<Domain.Entities.Quiz>> GetQuizzessByCreatorAsync(string userId);
    }
}