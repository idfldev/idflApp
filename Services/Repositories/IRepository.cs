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

    public interface IRepository<T> where T : BaseInterface
    {
        Task<T> CreateAsync(T entity);
        Task<bool> CreateRangeAsync(List<T> entity);
        Task<IParams<IEnumerable<T>>> PaginationGetAllAsync(int pageNumber, int pageSize, params Expression<Func<T, object>>[] includes);
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includes);
        Task<T> GetAsync(Guid id, params Expression<Func<T, object>>[] includes);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(Guid id);
        Task<bool> GetAnyAsync(Guid id, string value);
        Task<IEnumerable<T>> GetAllParamAsync(string propertyName, IEnumerable<Guid> id, params Expression<Func<T, object>>[] includes);
    }
}
