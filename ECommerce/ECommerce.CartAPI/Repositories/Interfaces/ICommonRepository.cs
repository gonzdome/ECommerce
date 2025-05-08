using System.Linq.Expressions;

namespace ECommerce.CartAPI.Repositories.Interfaces;

public interface ICommonRepository<T>
{
    Task<IEnumerable<T>> GetAll();
    Task<T> Details(Expression<Func<T, bool>> predicate);
    Task<T> Create(T entity);
    Task<T> Update(T entity);
    Task<T> Delete(T entity);
}