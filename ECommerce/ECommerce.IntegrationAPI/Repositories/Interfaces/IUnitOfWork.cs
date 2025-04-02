namespace ECommerce.IntegrationAPI.Repositories.Interfaces;

public interface IUnitOfWork
{
    IIntegrationRepository IntegrationRepository { get; }

    Task Commit();
}
