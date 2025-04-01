using System.Text.Json;

namespace ECommerce.IntegrationAPI.Gateways.PurchaseAPI.Services;

public class UnitOfWork : IUnitOfWork
{
    private readonly APIClient _apiClient;
    private IPurchaseAPIService _purchaseAPIService;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly JsonSerializerOptions _options;

    public UnitOfWork(IHttpClientFactory httpClientFactory, APIClient apiClient)
    {
        _httpClientFactory = httpClientFactory;
        _apiClient = new APIClient(_httpClientFactory);
    }

    public IPurchaseAPIService PurchaseAPIService
    {
        get { return _purchaseAPIService = _purchaseAPIService ?? new PurchaseAPIService(_apiClient); }
    }
}
