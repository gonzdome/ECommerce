namespace ECommerce.IntegrationAPI.Repositories;

public class UnitOfWork : IUnitOfWork
{
    public AppDbContext _context;
    private IIntegrationRepository? _productRepository;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public IIntegrationRepository IntegrationRepository
    {
        get { return _productRepository = _productRepository ?? new IntegrationRepository(_context); }
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
