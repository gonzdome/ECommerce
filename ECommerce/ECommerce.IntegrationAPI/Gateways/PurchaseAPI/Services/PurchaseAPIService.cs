namespace ECommerce.IntegrationAPI.Gateways.PurchaseAPI.Services;

public class PurchaseAPIService : PurchaseAPIGateway, IPurchaseAPIService
{
    public PurchaseAPIService(APIClient apiClient) : base(apiClient)
    {
    }

    public async Task<PurchaseAPIPostResponse> PurchaseAPISend(PurchaseAPIPostRequest purchaseAPIPostRequest, string ApiName, string ApiUri)
    {
        var purchaseResponse = await Purchase(purchaseAPIPostRequest, ApiName, ApiUri);
        return purchaseResponse;
    }
}
