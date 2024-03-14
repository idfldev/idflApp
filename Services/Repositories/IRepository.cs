using System.Linq.Expressions;
using idflApp.Core.Models.Interfaces;

namespace idflApp.Services.Repositories
{
    public class IParams<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int FirstPage { get; set; }
        public int LastPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public int NextPage { get; set; }
        public int PreviousPage { get; set; }
        public T Data { get; set; } // Add this property to hold the paginated data
    }

    // public interface IRepository<T, TResult> where T : BaseInterface
    // {
    //     Task<T> CreateAsync(T entity);
    //     Task<bool> CreateRangeAsync(List<T> entity);
    //     Task<IParams<IEnumerable<TResult>>> PaginationGetAllAsync(int pageNumber, int pageSize, Expression<Func<T, TResult>> selector, params Expression<Func<T, object>>[] includes);
    //     Task<IEnumerable<TResult>> GetAllAsync(Expression<Func<T, TResult>> selector, params Expression<Func<T, object>>[] includes);
    //     Task<T> UpdateAsync(T entity);
    //     Task<T> DeleteAsync(Guid id);
    //     Task<bool> GetAnyAsync(Guid id, string value);
    //     Task<IEnumerable<T>> GetAllParamAsync(string propertyName, IEnumerable<Guid> id, params Expression<Func<T, object>>[] includes);
    //     ///
    //     Task<TResult> GetDetailFilterAsync(Expression<Func<T, TResult>> selector, Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includes);
    // }
    public interface IRepository<TEntity, TResult> where TEntity : BaseInterface
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<bool> CreateRangeAsync(List<TEntity> entities);
        Task<IParams<IEnumerable<TResult>>> PaginateAllAsync(int pageNumber, int pageSize, Expression<Func<TEntity, TResult>> selector, params Expression<Func<TEntity, object>>[] includes);
        Task<IEnumerable<TResult>> GetAllAsync(Expression<Func<TEntity, TResult>> selector, params Expression<Func<TEntity, object>>[] includes);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(Guid id);
        Task<bool> ExistsAsync(Guid id, string value);
        Task<IEnumerable<TEntity>> GetAllByPropertyAsync(string propertyName, IEnumerable<Guid> ids, params Expression<Func<TEntity, object>>[] includes);
        Task<TResult> GetDetailFilteredAsync(Expression<Func<TEntity, TResult>> selector, Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes);
    }

}
