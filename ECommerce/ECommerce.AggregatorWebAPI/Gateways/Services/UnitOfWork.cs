using System.Text.Json;

namespace ECommerce.AggregatorWebAPI.Gateways.Services;

public class UnitOfWork : IUnitOfWork
{
    private readonly APIClient _apiClient;
    private IProductAPIProductsService? _productAPIProductsService;
    private IProductAPICategoriesService? _productAPICategoriesService;
    private IIntegrationAPIIntegrationService? _IntegrationAPIIntegrationService;
    private IIntegrationAPIPurchaseService? _IntegrationAPIPurchaseService;
    private IAuthAPIUsersService? _authAPIUsersService;
    private IAuthAPICategoriesService? _authAPICategoriesService;
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

    public IIntegrationAPIIntegrationService IntegrationAPIIntegrationService
    {
        get { return _IntegrationAPIIntegrationService = _IntegrationAPIIntegrationService ?? new IntegrationAPIIntegrationService(_apiClient); }
    }

    public IIntegrationAPIPurchaseService IntegrationAPIPurchaseService
    {
        get { return _IntegrationAPIPurchaseService = _IntegrationAPIPurchaseService ?? new IntegrationAPIPurchaseService(_apiClient); }
    }

    public IAuthAPIUsersService AuthAPIUsersService
    {
        get { return _authAPIUsersService = _authAPIUsersService ?? new AuthAPIUsersService(_apiClient); }
    }

    public IAuthAPICategoriesService AuthAPICategoriesService
    {
        get { return _authAPICategoriesService = _authAPICategoriesService ?? new AuthAPICategoriesService(_apiClient); }
    }
}
