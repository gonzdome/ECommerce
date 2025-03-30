using ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Services.Interfaces;
using ECommerce.APIHandler;
using System.Text.Json;

namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly APIClient _apiClient;
        private IProductAPIProductsService? _productAPIProductsService;
        private IProductAPICategoriesService? _productAPICategoriesService;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly JsonSerializerOptions _options;

        public UnitOfWork(IHttpClientFactory httpClientFactory, APIClient apiClient)
        {
            _httpClientFactory = httpClientFactory;
            _apiClient = new APIClient(_httpClientFactory);
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
