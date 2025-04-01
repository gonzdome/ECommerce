namespace ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Services.Interfaces;

public interface IIntegrationAPIService
{
    public Task<SendPurchaseViewModelResponse> IntegrationAPISendPurchase(SendPurchaseViewModel IntegrationAPIPostViewModelRequest);
}
