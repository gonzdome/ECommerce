using ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Models.ViewModels.Purchase;

namespace ECommerce.AggregatorWebAPI.Services.Interfaces;

public interface IPurchaseService
{
    Task<SendPurchaseViewModelResponse> SendPurchase(SendPurchaseViewModel request);
}
