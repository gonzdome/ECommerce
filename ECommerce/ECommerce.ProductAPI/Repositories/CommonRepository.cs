using System.Linq.Expressions;

namespace ECommerce.ProductAPI.Repositories;

public class CommonRepository<T> : ICommonRepository<T> where T : class
{
    protected readonly AppDbContext _context;

    public CommonRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return _context.Set<T>();
    }

    public async Task<T?> Details(Expression<Func<T, bool>> predicate)
    {
        return _context.Set<T>().FirstOrDefault(predicate);
    }

    public async Task<T> Create(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        return entity;
    }
    public async Task<T> Update(T entity)
    {
        _context.Set<T>().Update(entity);
        return entity;
    }

    public async Task<T> Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
        return entity;
    }
}
