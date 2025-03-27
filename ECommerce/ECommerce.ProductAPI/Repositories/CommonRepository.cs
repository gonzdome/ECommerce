using System.Linq.Expressions;

namespace ECommerce.ProductAPI.Repositories;

public class CommonRepository<T> : ICommonRepository<T> where T : class
{
    protected readonly AppDbContext _context;

    public CommonRepository(AppDbContext context)
    {
        _context = context;
    }
    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>();
    }

    public T? Details(Expression<Func<T, bool>> predicate)
    {
        return _context.Set<T>().FirstOrDefault(predicate);
    }

    public T Create(T entity)
    {
        _context.Set<T>().Add(entity);
        return entity;
    }
    public T Update(T entity)
    {
        _context.Set<T>().Update(entity);
        return entity;
    }

    public T Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
        return entity;
    }
}
