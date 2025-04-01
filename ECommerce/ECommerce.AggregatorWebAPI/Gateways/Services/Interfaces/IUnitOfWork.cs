namespace ECommerce.AggregatorWebAPI.Gateways.Services.Interfaces;

public interface IUnitOfWork
{
    public IProductAPIProductsService ProductAPIProductsService { get; }
    public IProductAPICategoriesService ProductAPICategoriesService { get; }
    public IIntegrationAPIService IntegrationAPIService { get; }
}
