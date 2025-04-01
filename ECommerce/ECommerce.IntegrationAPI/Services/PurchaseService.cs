namespace ECommerce.IntegrationAPI.Services;

public class PurchaseService : IPurchaseService
{
    private readonly IUnitOfWork _unitOfWork;

    public PurchaseService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

     public async Task<PurchaseAPIPostResponse> Purchase(PurchaseAPIPostRequest purchaseAPIPostRequest)
    {
        var purchaseResponse = await _unitOfWork.PurchaseAPIService.PurchaseAPISend(purchaseAPIPostRequest);
        return purchaseResponse;
    }
}
