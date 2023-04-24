using EmemIsaac.QuizManager.Domain.Entities;

namespace EmemIsaac.QuizManager.Application.Contracts.Persistence
{
    public interface IOptionsRepository : IAsyncRepository<Option, Guid>
    {
        Task<IReadOnlyList<Option>> GetByQuestionAsync(Guid questionId);
    }
}