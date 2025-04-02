namespace ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Services;

public class IntegrationAPIIntegrationService : IntegrationAPIIntegrationsGateway, IIntegrationAPIIntegrationService
{
    public IntegrationAPIIntegrationService(APIClient apiClient) : base(apiClient)
    {
    }

    public async Task<DetailIntegrationViewModelResponse> IntegrationAPIDetailIntegrationByFlow(string flowName)
    {
        var productDetails = await DetailIntegrationByFlow(flowName);
        return productDetails;
    }

    public async Task<GetIntegrationsViewModelResponse> IntegrationAPIGetIntegrations()
    {
        var productsListed = await GetIntegrations();
        return productsListed;
    }

    public async Task<CreateIntegrationViewModelResponse> IntegrationAPICreateIntegration(CreateIntegrationViewModel product)
    {
        var createdIntegration = await CreateIntegration(product);
        return createdIntegration;
    }

    public async Task<UpdateIntegrationViewModelResponse> IntegrationAPIUpdateIntegrationById(UpdateIntegrationViewModel product)
    {
        var updatedIntegration = await UpdateIntegrationById(product);
        return updatedIntegration;
    }

    public async Task<DetailIntegrationViewModelResponse> IntegrationAPIDeleteIntegrationById(string id)
    {
        var deletedIntegration = await DeleteIntegrationById(id);
        return deletedIntegration;
    }
}