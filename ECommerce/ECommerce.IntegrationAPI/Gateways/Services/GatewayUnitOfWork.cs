using System.Text.Json;
using ECommerce.IntegrationAPI.Gateways.Services.Interfaces;

namespace ECommerce.IntegrationAPI.Gateways.Services;

public class GatewayUnitOfWork : IGatewayUnitOfWork
{
    private readonly APIClient _apiClient;
    private IPurchaseAPIService _purchaseAPIService;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly JsonSerializerOptions _options;

    public GatewayUnitOfWork(IHttpClientFactory httpClientFactory, APIClient apiClient)
    {
        _httpClientFactory = httpClientFactory;
        _apiClient = new APIClient(_httpClientFactory);
    }

    public IPurchaseAPIService PurchaseAPIService
    {
        get { return _purchaseAPIService = _purchaseAPIService ?? new PurchaseAPIService(_apiClient); }
    }
}
