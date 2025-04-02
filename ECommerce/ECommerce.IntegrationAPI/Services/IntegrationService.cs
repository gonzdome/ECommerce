namespace ECommerce.IntegrationAPI.Services;

public class IntegrationService : IIntegrationService
{
    private readonly IUnitOfWork _unitOfWork;

    public IntegrationService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IntegrationDTO> DetailIntegrationByFlow(string flowName)
    {
        var integration = await GetAndReturnIntegrationByFlowName(flowName);

        return integration.MapToIntegrationDTO();
    }

    public async Task<IEnumerable<IntegrationDTO>> GetIntegrations()
    {
        IEnumerable<Integration> integrations = (await _unitOfWork.IntegrationRepository.GetAll()).Where(i => !i.Excluded && i.Active);

        var integrationsMapped = integrations.Select(i => i.MapToIntegrationDTO());

        return integrationsMapped;
    }

    public async Task<IntegrationDTO> CreateIntegration(IntegrationDTO integrationToCreate)
    {
        Integration mappedToIntegration = integrationToCreate.MapToIntegration();

        mappedToIntegration.CreatedAt = DateTime.Now;
        mappedToIntegration.UpdatedAt = DateTime.Now;


        var integrationCreated = await _unitOfWork.IntegrationRepository.Create(mappedToIntegration);
        await _unitOfWork.Commit();

        return integrationCreated.MapToIntegrationDTO();
    }

    public async Task<IntegrationDTO> UpdateIntegrationById(IntegrationDTO integrationToUpdate)
    {
        await GetAndReturnIntegrationById(integrationToUpdate.Id.ToString());

        var mappedIntegration = integrationToUpdate.MapToIntegration();

        mappedIntegration.UpdatedAt = DateTime.Now;

        await _unitOfWork.IntegrationRepository.Update(mappedIntegration);
        await _unitOfWork.Commit();

        return mappedIntegration.MapToIntegrationDTO();
    }

    public async Task<IntegrationDTO> DeleteIntegrationById(string id)
    {
        var foundIntegration = await GetAndReturnIntegrationById(id);
        
        foundIntegration.Excluded = true;

        await _unitOfWork.IntegrationRepository.Update(foundIntegration);
        await _unitOfWork.Commit();

        return foundIntegration.MapToIntegrationDTO();
    }

    private async Task<Integration> GetAndReturnIntegrationByFlowName(string flowName)
    {
        var integration = await _unitOfWork.IntegrationRepository.Details(i => i.Flow == flowName && !i.Excluded && i.Active);
        if (integration == null)
            throw new Exception($"Integration with Flow {flowName} not found!");

        return integration;
    }

    private async Task<Integration> GetAndReturnIntegrationById(string id)
    {
        var integration = await _unitOfWork.IntegrationRepository.Details(i => i.Id == Guid.Parse(id) && !i.Excluded && i.Active);
        if (integration == null)
            throw new Exception($"Integration with id {id} not found!");

        return integration;
    }
}
