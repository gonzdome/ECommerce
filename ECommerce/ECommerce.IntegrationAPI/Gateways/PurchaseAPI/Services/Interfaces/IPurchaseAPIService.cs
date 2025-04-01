namespace ECommerce.IntegrationAPI.Gateways.PurchaseAPI.Services.Interfaces;

public interface IPurchaseAPIService
{
    public Task<PurchaseAPIPostResponse> PurchaseAPISend(PurchaseAPIPostRequest purchaseAPIPostRequest);
}
