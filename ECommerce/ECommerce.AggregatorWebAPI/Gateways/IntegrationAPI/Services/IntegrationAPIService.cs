using ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI;

namespace ECommerce.AggregatorWebAPI.Gateways.ProductAPI.Services;

public class IntegrationAPIService : IntegrationAPIGateway, IIntegrationAPIService
{
    public IntegrationAPIService(APIClient apiClient) : base(apiClient)
    {
    }

    public async Task<SendPurchaseViewModelResponse> IntegrationAPISendPurchase(SendPurchaseViewModel IntegrationAPIPostViewModelRequest)
    {
        var purchaseResponse = await IntegrationAPIPurchase(IntegrationAPIPostViewModelRequest);
        return purchaseResponse;
    }
}