using Alphastellar.Case.CoreLayer.Entities.Abstract;
using Alphastellar.Case.CoreLayer.Interfaces.Repositories;
using Alphastellar.Case.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Alphastellar.Case.DataAccessLayer.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Vehicle, IBaseEntity, new()
    {

        protected readonly AppDbContext _appDbContext;
        public BaseRepository(AppDbContext appDbContext) => (_appDbContext) = (appDbContext);
        protected DbSet<T> _dbSet => _appDbContext.Set<T>();

        //write
        public async Task<T> AddAsync(T entity)
        {
            var response = await _dbSet.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();
            return response.Entity;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);

            if (entity == null)
                return false;

            _dbSet.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        public T Update(T entity)
        {
            _dbSet.Update(entity);
            _appDbContext.SaveChanges();
            return entity;
        }


        //read
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetByColorAsync(string color)
        {
            return await _dbSet.Where(x => x.Color == color.ToLower()).ToListAsync();
        }

        public async Task<T> GetDefault(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.FirstOrDefaultAsync(expression);
        }

        public async Task<List<T>> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.Where(expression).ToListAsync();
        }
    }
}
