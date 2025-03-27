using System.Linq.Expressions;

namespace ECommerce.ProductAPI.Repositories.Interfaces;

public interface ICommonRepository<T>
{
    IEnumerable<T> GetAll();
    T? Details(Expression<Func<T, bool>> predicate);
    T Create(T entity);
    T Update(T entity);
    T Delete(T entity);
}
