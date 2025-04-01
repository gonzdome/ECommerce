namespace ECommerce.AggregatorWebAPI.Services.Interfaces;

public interface IIntegrationService
{
    Task<SendPurchaseViewModelResponse> SendPurchase(SendPurchaseViewModel request);
}
