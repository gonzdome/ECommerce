namespace ECommerce.IntegrationAPI.Repositories;

public class IntegrationRepository : CommonRepository<Integration>, IIntegrationRepository
{
    public IntegrationRepository(AppDbContext context) : base(context)
    {
    }
}
