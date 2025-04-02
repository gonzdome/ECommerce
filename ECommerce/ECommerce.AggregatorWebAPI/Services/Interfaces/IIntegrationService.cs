namespace ECommerce.AggregatorWebAPI.Services.Interfaces;

public interface IIntegrationService
{
    Task<GetIntegrationsViewModelResponse> GetIntegrations();
    Task<DetailIntegrationViewModelResponse> DetailIntegrationByFlow(string flowName);
    Task<CreateIntegrationViewModelResponse> CreateIntegration(CreateIntegrationViewModel product);
    Task<UpdateIntegrationViewModelResponse> UpdateIntegrationById(UpdateIntegrationViewModel product);
    Task<DetailIntegrationViewModelResponse> DeleteIntegrationById(string id);
}
