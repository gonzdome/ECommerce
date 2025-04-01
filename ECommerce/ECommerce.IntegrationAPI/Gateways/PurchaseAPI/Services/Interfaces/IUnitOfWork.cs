namespace ECommerce.IntegrationAPI.Gateways.PurchaseAPI.Services.Interfaces;

public interface IUnitOfWork
{
    public IPurchaseAPIService PurchaseAPIService { get; }
}
