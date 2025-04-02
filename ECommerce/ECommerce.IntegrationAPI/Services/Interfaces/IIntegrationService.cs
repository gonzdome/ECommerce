namespace ECommerce.IntegrationAPI.Services.Interfaces;

public interface IIntegrationService
{
    public Task<IEnumerable<IntegrationDTO>> GetIntegrations();
    public Task<IntegrationDTO> DetailIntegrationByFlow(string flowName);
    public Task<IntegrationDTO> CreateIntegration(IntegrationDTO integration);
    public Task<IntegrationDTO> UpdateIntegrationById(IntegrationDTO integration);
    public Task<IntegrationDTO> DeleteIntegrationById(string id);
}
