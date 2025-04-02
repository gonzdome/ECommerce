namespace ECommerce.IntegrationAPI.Gateways.PurchaseAPI.Services;

public class PurchaseAPIService : PurchaseAPIGateway, IPurchaseAPIService
{
    public PurchaseAPIService(APIClient apiClient) : base(apiClient)
    {
    }

    public async Task<PurchaseAPIPostResponse> PurchaseAPISend(PurchaseAPIPostRequest purchaseAPIPostRequest)
    {
        var purchaseResponse = await Purchase(purchaseAPIPostRequest);
        return purchaseResponse;
    }
}
