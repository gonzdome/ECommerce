namespace ECommerce.ProductAPI.Repositories;

public class ProductRepository : CommonRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context)
    {
    }
}
