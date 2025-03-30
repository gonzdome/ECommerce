namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Services.Interfaces;

public interface IUnitOfWork
{
    public IProductAPIProductsService ProductAPIProductsService { get; }
    public IProductAPICategoriesService ProductAPICategoriesService { get; }
}
