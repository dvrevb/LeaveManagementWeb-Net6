using System.Collections.Generic;

namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<bool> Exists(int id);
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(List<T> entites);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
    }
}
