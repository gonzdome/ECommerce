namespace ECommerce.IntegrationAPI.Gateways.PurchaseAPI.Services;

public class PurchaseAPIService : PurchaseAPIGateway, IPurchaseAPIService
{
    public PurchaseAPIService(APIClient apiClient) : base(apiClient)
    {
    }

    public async Task<PurchaseAPIPostResponse> PurchaseAPISend(PurchaseAPIPostRequest request, string ApiName, string ApiUri)
    {
        var purchaseResponse = await Purchase(request, ApiName, ApiUri);
        return purchaseResponse;
    }
}
