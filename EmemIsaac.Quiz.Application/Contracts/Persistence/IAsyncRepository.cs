namespace EmemIsaac.Quiz.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T, TId> where T : class
    {
        Task<T> CreateAsync(T entity);
                
        Task<T> UpdateAsync(T entity);
        
        Task<T> DeleteAsync(T entity);

        Task<T> GetByIdAsync(TId id);

        Task<IReadOnlyList<T>> GetAllAsync();

        Task<IReadOnlyList<T>> GetPagedAsync(int page, int pageSize);
    }
}