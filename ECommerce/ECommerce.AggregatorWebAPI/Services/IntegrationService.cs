namespace ECommerce.AggregatorWebAPI.Services;

public class IntegrationService : IIntegrationService
{
    private readonly IUnitOfWork _unitOfWork;

    public IntegrationService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<SendPurchaseViewModelResponse> SendPurchase(SendPurchaseViewModel request)
    {
        var result = await _unitOfWork.IntegrationAPIService.IntegrationAPISendPurchase(request);
        return new SendPurchaseViewModelResponse();
    }
}
