using ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Models.ViewModels.Purchase;

namespace ECommerce.AggregatorWebAPI.Services;

public class PurchaseService : IPurchaseService
{
    private readonly IUnitOfWork _unitOfWork;

    public PurchaseService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<SendPurchaseViewModelResponse> SendPurchase(SendPurchaseViewModel request)
    {
        var result = await _unitOfWork.IntegrationAPIPurchaseService.IntegrationAPISendPurchase(request);
        return new SendPurchaseViewModelResponse();
    }
}
