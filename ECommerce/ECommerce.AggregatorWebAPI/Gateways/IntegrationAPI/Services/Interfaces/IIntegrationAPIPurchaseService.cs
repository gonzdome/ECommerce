namespace ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Services.Interfaces;

public interface IIntegrationAPIPurchaseService
{
    public Task<SendPurchaseViewModelResponse> IntegrationAPISendPurchase(SendPurchaseViewModel IntegrationAPIPostViewModelRequest);
}
