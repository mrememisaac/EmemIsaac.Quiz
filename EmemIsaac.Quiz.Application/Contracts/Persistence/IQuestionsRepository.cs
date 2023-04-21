using EmemIsaac.Quiz.Domain.Entities;

namespace EmemIsaac.Quiz.Application.Contracts.Persistence
{
    public interface IQuestionsRepository : IAsyncRepository<Question, Guid>
    {
        Task<IReadOnlyList<Option>> GetBySubjectAsync(Guid subjectId);
    }
}