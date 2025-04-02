namespace ECommerce.AggregatorWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class IntegrationController : ControllerBase
{
    private readonly IIntegrationService _integrationService;

    public IntegrationController(IIntegrationService integrationService)
    {
        _integrationService = integrationService;
    }

    [HttpGet("GetIntegrations")]
    public async Task<ActionResult<IEnumerable<GetIntegrationsViewModelResponse>>> GetIntegrations()
    {
        var integration = await _integrationService.GetIntegrations();
        return Ok(integration);
    }

    [HttpGet("GetIntegrationDetailsByFlow")]
    public async Task<ActionResult<DetailIntegrationViewModelResponse>> GetIntegrationDetailsByFlow([FromQuery] string flowName)
    {
        var integration = await _integrationService.DetailIntegrationByFlow(flowName);
        return Ok(integration);
    }

    [HttpPost]
    [Route("CreateIntegration")]
    public async Task<ActionResult<CreateIntegrationViewModelResponse>> CreateIntegration([FromBody] CreateIntegrationViewModel integrationPayload)
    {
        var integration = await _integrationService.CreateIntegration(integrationPayload);
        return Ok(integration);
    }

    [HttpPut("UpdateIntegrationById")]
    public async Task<ActionResult<UpdateIntegrationViewModelResponse>> UpdateIntegrationById([FromBody] UpdateIntegrationViewModel integrationToUpdate)
    {
        var integration = await _integrationService.UpdateIntegrationById(integrationToUpdate);
        return Ok(integration);
    }

    [HttpDelete("DeleteIntegrationById")]
    public async Task<ActionResult<DetailIntegrationViewModelResponse>> DeleteIntegrationById([FromQuery] string id)
    {
        var integration = await _integrationService.DeleteIntegrationById(id);
        return Ok(integration);
    }
}