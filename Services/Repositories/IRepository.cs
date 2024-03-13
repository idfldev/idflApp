using idflApp.Core.Models.Interfaces;
using System.Linq.Expressions;

namespace idflApp.Services.Repositories
{
    public interface IRepository<T> where T : BaseInterface
    {
        Task<T> CreateAsync(T entity);
        Task<T> CreateRangeAsync(List<T> entity);
        Task<IReadOnlyCollection<T>> GetAllAsync(params Expression<Func<T, object>>[] includes);
        Task<T> GetAsync(Guid id , params Expression<Func<T, object>>[] includes);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(Guid id);
    }
}
