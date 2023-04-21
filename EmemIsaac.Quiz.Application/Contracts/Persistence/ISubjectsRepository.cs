using EmemIsaac.Quiz.Domain.Entities;

namespace EmemIsaac.Quiz.Application.Contracts.Persistence
{
    public interface ISubjectsRepository : IAsyncRepository<Subject, Guid>
    {
        Task<IReadOnlyList<Subject>> GetSubjectsByCreatorAsync(string userId);
    }
}