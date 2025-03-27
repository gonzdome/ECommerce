namespace ECommerce.ProductAPI.Repositories;

public class UnitOfWork
{
    public AppDbContext _context;
    private IProductRepository? _productRepository;
    private IPurchaseRepository? _purchaseRepository;

    public UnitOfWork(IProductRepository? productRepository, IPurchaseRepository purchaseRepository)
    {
        _productRepository = productRepository;
        _purchaseRepository = purchaseRepository;
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
