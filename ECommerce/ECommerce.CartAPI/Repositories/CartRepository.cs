namespace ECommerce.CartAPI.Repositories;

public class CartRepository : CommonRepository<Cart>, ICartRepository
{
    public CartRepository(AppDbContext context) : base(context)
    {
    }
}
