using System.Collections.Generic;

namespace LeaveManagement.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : class
{
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(T entity);
    Task<T> GetAsync(int id);
    Task<IReadOnlyList<T>> GetAllAsync();
}