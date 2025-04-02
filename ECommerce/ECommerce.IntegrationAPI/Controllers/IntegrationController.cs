namespace ECommerce.IntegrationAPI.Controllers;

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
    public async Task<ActionResult<IEnumerable<IntegrationDTO>>> GetIntegrations()
    {
        try
        {
            var integration = await _integrationService.GetIntegrations();
            return Ok(integration);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpGet("GetIntegrationDetailsByFlow")]
    public async Task<ActionResult<IntegrationDTO>> GetIntegrationDetailsByFlow([FromQuery] string flowName)
    {
        try
        {
            var integration = await _integrationService.DetailIntegrationByFlow(flowName);
            return Ok(integration);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpPost]
    [Route("CreateIntegration")]
    public async Task<ActionResult<IntegrationDTO>> CreateIntegration(IntegrationDTO integrationPayload)
    {
        try
        {
            var integration = await _integrationService.CreateIntegration(integrationPayload);
            return Ok(integration);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpPut("UpdateIntegrationById")]
    public async Task<ActionResult<IntegrationDTO>> UpdateIntegrationById(IntegrationDTO integrationToUpdate)
    {
        try
        {
            var integration = await _integrationService.UpdateIntegrationById(integrationToUpdate);
            return integration;
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteIntegrationById")]
    public async Task<ActionResult<IntegrationDTO>> DeleteIntegrationById([FromQuery] string id)
    {
        try
        {
            var integration = await _integrationService.DeleteIntegrationById(id);
            return Ok(integration);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
}
