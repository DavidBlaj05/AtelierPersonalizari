using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AtelierPersonalizariAPI.Models.BaseEntity;
using AtelierPersonalizariAPI.Data;

namespace AtelierPersonalizariAPI.Repositories.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly AtelierPersonalizariContext _context;
        protected readonly DbSet<TEntity> _table;

        public GenericRepository(AtelierPersonalizariContext context)
        {
            _context = context;
            _table = _context.Set<TEntity>();
        }


        public async Task<List<TEntity>> GetAll()
        {
            return await _table.AsNoTracking().ToListAsync();
        }


        // Create
        public void Create(TEntity entity)
        {
            _table.Add(entity);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
        }

        public void CreateRange(IEnumerable<TEntity> entities)
        {
            _table.AddRange(entities);
        }

        public async Task CreateRangeAsync(IEnumerable<TEntity> entities)
        {
            await _table.AddRangeAsync(entities);
        }


        // Update
        public void Update(TEntity entity)
        {
            _table.Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _table.UpdateRange(entities);
        }


        // Delete
        public void Delete(TEntity entity)
        {
            _table.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _table.RemoveRange(entities);
        }


        // Find
        public TEntity FindById(object id)
        {
            return _table.Find(id);
        }

        public async Task<TEntity> FindByIdAsync(object id)
        {
            return await _table.FindAsync(id);
        }
    }
}
