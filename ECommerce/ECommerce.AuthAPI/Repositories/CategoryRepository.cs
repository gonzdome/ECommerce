namespace ECommerce.AuthAPI.Repositories;

public class CategoryRepository : CommonRepository<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context)
    {
    }
}
