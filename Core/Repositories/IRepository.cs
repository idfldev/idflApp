using System.Linq.Expressions;
using idflApp.Core.Models.Interfaces;

namespace idflApp.Services.Repositories
{
    public class IParams<TResult>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int FirstPage { get; set; }
        public int LastPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public int NextPage { get; set; }
        public int PreviousPage { get; set; }
        public TResult Data { get; set; }
    }
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
