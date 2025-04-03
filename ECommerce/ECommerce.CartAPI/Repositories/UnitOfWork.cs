namespace ECommerce.CartAPI.Repositories;

public class UnitOfWork : IUnitOfWork
{
    public AppDbContext _context;
    private ICartRepository? _productRepository;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public ICartRepository CartRepository
    {
        get { return _productRepository = _productRepository ?? new CartRepository(_context); }
    }

    public async Task Commit()
    {
        _context.SaveChanges();
    }

    public async Task Dispose()
    {
        _context.Dispose();
    }
}
