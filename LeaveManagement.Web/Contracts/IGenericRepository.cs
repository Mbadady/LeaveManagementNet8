namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);

        Task DeleteAsync(int id);
        Task DeleteAllAsync();

        Task<T?> GetAsync(int? id);

        Task<List<T>> GetAllAsync();

        Task<bool> ExistsAsync(int id);

    }
}
