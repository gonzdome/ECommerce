
namespace ECommerce.ProductAPI.Repositories;

public class PurchaseRepository : CommonRepository<Purchase>, IPurchaseRepository
{
    public PurchaseRepository(AppDbContext context) : base(context)
    {
    }
}
