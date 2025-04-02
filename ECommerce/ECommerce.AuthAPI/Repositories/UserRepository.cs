namespace ECommerce.AuthAPI.Repositories;

public class UserRepository : CommonRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }
}
