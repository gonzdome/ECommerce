namespace ECommerce.IntegrationAPI.Gateways.Services.Interfaces;

public interface IGatewayUnitOfWork
{
    public IPurchaseAPIService PurchaseAPIService { get; }
}
