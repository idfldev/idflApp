using AutoMapper;
using idflApp.Core.Models.Interfaces;
using idflApp.Data;
using idflApp.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Xml;

namespace idflApp.Services.Repositories
{

    public class MySqlRepository<TEntity, TResult> : IRepository<TEntity, TResult> where TEntity : BaseInterface
    {

        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _entities;

        public MySqlRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _entities = _context.Set<TEntity>();
        }
        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> CreateRangeAsync(List<TEntity> entities)
        {
            if (entities == null || entities.Count == 0)
                throw new ArgumentNullException(nameof(entities));
            await _entities.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<TEntity> DeleteAsync(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("ID cannot be empty.", nameof(id));

            var entityToDelete = await _entities.FirstOrDefaultAsync(e => e.Id == id);
            if (entityToDelete == null)
                throw new Exception($"Entity with ID {id} not found.");
            _entities.Remove(entityToDelete);
            await _context.SaveChangesAsync();
            return entityToDelete;


            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TResult>> GetAllAsync(Expression<Func<TEntity, TResult>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _entities.AsQueryable();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.Select(selector).ToListAsync();

        }
        public async Task<IParams<IEnumerable<TResult>>> PaginateAllAsync(int pageNumber, int pageSize, Expression<Func<TEntity, TResult>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _entities.AsQueryable();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            var TotalRecords = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(TotalRecords / (double)pageSize);
            var data = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).Select(selector).ToListAsync();
            return new IParams<IEnumerable<TResult>>
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
        public async Task<bool> ExistsAsync(Guid id, string propertyName)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("ID cannot be empty.", nameof(id));

            return await _entities.AnyAsync(e => EF.Property<Guid>(e, propertyName) == id);
        }
        public async Task<TResult> GetDetailFilteredAsync(Expression<Func<TEntity, TResult>> selector, Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _entities.AsQueryable();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.Where(filter).Select(selector).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<TEntity>> GetAllByPropertyAsync(string propertyName, IEnumerable<Guid> ids, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _entities.AsQueryable();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            var data = await query.Where(i => ids.Contains(EF.Property<Guid>(i, propertyName))).ToListAsync();
            return data;
        }
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            var existingEntity = await _entities.FirstOrDefaultAsync(e => e.Id == entity.Id);

            if (existingEntity == null)
                throw new Exception($"Entity with ID {entity.Id} not found.");

           _entities.Entry(existingEntity).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return existingEntity;
        }

        public async Task UpdateRangeAsync(List<TEntity> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            // Load existing entities from the database
            var existingEntities = await _entities.Where(e => entities.Select(x => x.Id).Contains(e.Id)).ToListAsync();

            // Update each entity individually
            foreach (var entity in entities)
            {
                // Find the corresponding existing entity
                var existingEntity = existingEntities.FirstOrDefault(e => e.Id == entity.Id);
                if (existingEntity != null)
                {
                    // Update the properties of the existing entity
                    _context.Entry(existingEntity).CurrentValues.SetValues(entity);
                }
            }
        
            // Save changes to the database
            await _context.SaveChangesAsync();
        }

    }
}
