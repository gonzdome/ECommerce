using ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Services.Interfaces;
using ECommerce.APIHandler;

namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly APIClient _apiClient;
        private IProductAPIProductsService? _productAPIProductsService;
        private IProductAPICategoriesService? _productAPICategoriesService;

        public UnitOfWork(IServiceScopeFactory scoppedFactory, APIClient apiClient)
        {
            _apiClient = apiClient;
        }

        public IProductAPIProductsService ProductAPIProductsService
        {
            get { return _productAPIProductsService = _productAPIProductsService ?? new ProductAPIProductsService(_apiClient); }
        }

        public IProductAPICategoriesService ProductAPICategoriesService
        {
            get { return _productAPICategoriesService = _productAPICategoriesService ?? new ProductAPICategoriesService(_apiClient); }
        }
    }
}
