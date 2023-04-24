using EmemIsaac.QuizManager.Domain.Entities;

namespace EmemIsaac.QuizManager.Application.Contracts.Persistence
{
    public interface IQuestionsRepository : IAsyncRepository<Question, Guid>
    {
        Task<IReadOnlyList<Option>> GetBySubjectAsync(Guid subjectId);
    }
}