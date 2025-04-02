namespace ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Services.Interfaces;

public interface IIntegrationAPIIntegrationService
{
    public Task<GetIntegrationsViewModelResponse> IntegrationAPIGetIntegrations();
    public Task<DetailIntegrationViewModelResponse> IntegrationAPIDetailIntegrationByFlow(string flowName);
    public Task<CreateIntegrationViewModelResponse> IntegrationAPICreateIntegration(CreateIntegrationViewModel product);
    public Task<UpdateIntegrationViewModelResponse> IntegrationAPIUpdateIntegrationById(UpdateIntegrationViewModel product);
    public Task<DetailIntegrationViewModelResponse> IntegrationAPIDeleteIntegrationById(string id);
}
