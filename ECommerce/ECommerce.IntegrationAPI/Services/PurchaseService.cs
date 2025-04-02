namespace ECommerce.IntegrationAPI.Services;

public class PurchaseService : IPurchaseService
{
    private readonly IGatewayUnitOfWork _gatewayUnitOfWork;

    public PurchaseService(IGatewayUnitOfWork gatewayUnitOfWork)
    {
        _gatewayUnitOfWork = gatewayUnitOfWork;
    }

    public async Task<PurchaseAPIPostResponse> Purchase(PurchaseAPIPostRequest purchaseAPIPostRequest)
    {
        var purchaseResponse = await _gatewayUnitOfWork.PurchaseAPIService.PurchaseAPISend(purchaseAPIPostRequest);
        return purchaseResponse;
    }
}
