namespace ECommerce.ProductAPI.Repositories;

public class UnitOfWork : IUnitOfWork
{
    public AppDbContext _context;
    private IProductRepository? _productRepository;
    private IPurchaseRepository? _purchaseRepository;

    public UnitOfWork(IProductRepository? productRepository, IPurchaseRepository? purchaseRepository)
    {
        _productRepository = productRepository;
        _purchaseRepository = purchaseRepository;
    }

    public IProductRepository ProductRepository
    {
        get { return _productRepository = _productRepository ?? new ProductRepository(_context); }
    }

    public IPurchaseRepository PurchaseRepository
    {
        get { return _purchaseRepository = _purchaseRepository ?? new PurchaseRepository(_context); }
    }

    public void Commit()
    {
        _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
