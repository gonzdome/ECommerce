namespace ECommerce.IntegrationAPI.Services.Interfaces;

public interface IPurchaseService
{
    Task<PurchaseAPIPostResponse> Purchase(SendPurchaseRequest request, string ApiName, string ApiUri);
}
