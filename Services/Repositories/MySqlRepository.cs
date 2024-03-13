using idflApp.Core.Models.Interfaces;
using idflApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace idflApp.Services.Repositories
{
    public class MySqlRepository<T> : IRepository<T> where T : BaseInterface
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _contextSet;

        public MySqlRepository(ApplicationDbContext context)
        {
            _context = context;
            _contextSet = _context.Set<T>();
        }
        public async Task<T> CreateAsync(T entity)
        {
            if (entity != null)
            {
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            throw new NotImplementedException();
        }

        public async Task<T> CreateRangeAsync(List<T> entity)
        {
             if (entity != null)
            {
                await _contextSet.AddRangeAsync(entity);
                await _context.SaveChangesAsync();
            }
          throw new ArgumentNullException(nameof(entity), "Entity list cannot be null.");
        }

        public async Task<T> DeleteAsync(Guid id)
        {
            if (id != Guid.Empty)
            {
                var existingEntity = await _contextSet.FirstOrDefaultAsync(x => x.Id == id);
                if (existingEntity != null)
                {
                    _contextSet.Remove(existingEntity);
                    await _context.SaveChangesAsync();
                }
            }
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyCollection<T>> GetAllAsync(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _contextSet.AsQueryable();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.ToListAsync();
        }

        public async Task<T> GetAsync(Guid id, params Expression<Func<T, object>>[] includes)
        {
            // Create a query context data
            IQueryable<T> query = _contextSet.AsQueryable();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            var data = await query.FirstAsync(x => x.Id == id);
            return data;
        }

        public async Task<T> UpdateAsync(T dto)
        {
            if (dto != null)
            {
                var existingEntity = await _contextSet.FirstOrDefaultAsync(x => x.Id == dto.Id);
                if (existingEntity != null)
                {
                    _contextSet.Entry(existingEntity).CurrentValues.SetValues(dto);
                    await _context.SaveChangesAsync();
                    return existingEntity;
                }
                else
                {
                    throw new Exception("Entity not found for the provided ID.");
                }
            }
            else
            {
                throw new Exception("Entity not found for the provided ID.");
            }
        }
    }
}
