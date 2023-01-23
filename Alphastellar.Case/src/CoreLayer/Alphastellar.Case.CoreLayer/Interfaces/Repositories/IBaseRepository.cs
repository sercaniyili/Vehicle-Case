using Alphastellar.Case.CoreLayer.Entities.Abstract;
using System.Linq.Expressions;

namespace Alphastellar.Case.CoreLayer.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class, IBaseEntity
    {
        //read
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetByColorAsync(string color);
        Task<T> GetDefault(Expression<Func<T, bool>> expression);
        Task<List<T>> GetDefaults(Expression<Func<T, bool>> expression);

        //write
        Task<T> AddAsync(T entity);
        T Update(T entity);
        Task<bool> DeleteAsync(int id);

    }
}
