namespace ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Services;

public class IntegrationAPIPurchaseService : IntegrationAPIPurchaseGateway, IIntegrationAPIPurchaseService
{
    public IntegrationAPIPurchaseService(APIClient apiClient) : base(apiClient)
    {
    }

    public async Task<SendPurchaseViewModelResponse> IntegrationAPISendPurchase(SendPurchaseViewModel IntegrationAPIPostViewModelRequest)
    {
        var purchaseResponse = await IntegrationAPIPurchase(IntegrationAPIPostViewModelRequest);
        return purchaseResponse;
    }
}