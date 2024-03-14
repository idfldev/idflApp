using AutoMapper;
using idflApp.Core.Models.Interfaces;
using idflApp.Data;
using idflApp.Exceptions;
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
            throw new CreateException();
        }

        public async Task<bool> CreateRangeAsync(List<T> entity)
        {
            if (entity != null)
            {
                await _context.AddRangeAsync(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            throw new CreateException();
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
                    return existingEntity;
                }
            }
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _contextSet.AsQueryable();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.ToListAsync();

        }
        public async Task<IParams<IEnumerable<T>>> PaginationGetAllAsync(int pageNumber, int pageSize, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _contextSet.AsQueryable();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            var TotalRecords = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(TotalRecords / (double)pageSize);
            var data =await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            return new IParams<IEnumerable<T>>
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                FirstPage = 1,
                LastPage = totalPages,
                TotalPages = totalPages,
                TotalRecords = TotalRecords,
                NextPage = pageNumber < totalPages ? pageNumber + 1 : totalPages,
                PreviousPage = pageNumber > 1 ? pageNumber - 1 : 1,
                Data = data
            };

        }
        public async Task<bool> GetAnyAsync(Guid id, string value)
        {
            IQueryable<T> query = _contextSet.AsQueryable();
            return await _contextSet.AnyAsync(s => EF.Property<Guid>(s, value).Equals(id));
        }
        public async Task<IEnumerable<T>> GetAllParamAsync(string propertyName, IEnumerable<Guid> id, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _contextSet.AsQueryable();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            var data = await query.Where(i => id.Contains(EF.Property<Guid>(i, propertyName))).ToListAsync();
            return data;
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
