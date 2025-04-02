namespace ECommerce.AggregatorWebAPI.Services;

public class IntegrationService : IIntegrationService
{
    private readonly IUnitOfWork _unitOfWork;

    public IntegrationService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<GetIntegrationsViewModelResponse> GetIntegrations()
    {
        var response = await _unitOfWork.IntegrationAPIIntegrationService.IntegrationAPIGetIntegrations();
        return response;
    }

    public async Task<DetailIntegrationViewModelResponse> DetailIntegrationByFlow(string flowName)
    {
        var response = await _unitOfWork.IntegrationAPIIntegrationService.IntegrationAPIDetailIntegrationByFlow(flowName);
        return response;
    }

    public async Task<CreateIntegrationViewModelResponse> CreateIntegration(CreateIntegrationViewModel integration)
    {
        var response = await _unitOfWork.IntegrationAPIIntegrationService.IntegrationAPICreateIntegration(integration);
        return response;
    }

    public async Task<UpdateIntegrationViewModelResponse> UpdateIntegrationById(UpdateIntegrationViewModel integration)
    {
        var response = await _unitOfWork.IntegrationAPIIntegrationService.IntegrationAPIUpdateIntegrationById(integration);
        return response;
    }

    public async Task<DetailIntegrationViewModelResponse> DeleteIntegrationById(string id)
    {
        var response = await _unitOfWork.IntegrationAPIIntegrationService.IntegrationAPIDeleteIntegrationById(id);
        return response;
    }
}
