using EmemIsaac.Quiz.Domain.Entities;

namespace EmemIsaac.Quiz.Application.Contracts.Persistence
{
    public interface IOptionsRepository : IAsyncRepository<Option, Guid>
    {
        Task<IReadOnlyList<Option>> GetByQuestionAsync(Guid questionId);
    }
}