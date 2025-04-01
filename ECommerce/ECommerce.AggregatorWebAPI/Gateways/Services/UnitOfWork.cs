using System.Text.Json;

namespace ECommerce.AggregatorWebAPI.Gateways.Services;

public class UnitOfWork : IUnitOfWork
{
    private readonly APIClient _apiClient;
    private IProductAPIProductsService? _productAPIProductsService;
    private IProductAPICategoriesService? _productAPICategoriesService;
    private IIntegrationAPIService? _IntegrationAPIService;
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

    public IIntegrationAPIService IntegrationAPIService
    {
        get { return _IntegrationAPIService = _IntegrationAPIService ?? new IntegrationAPIService(_apiClient); }
    }

}
