using ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Models.ViewModels;

namespace ECommerce.AggregatorWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class IntegrationController : ControllerBase
{
    private readonly IIntegrationService _integrationService;

    public IntegrationController(IIntegrationService categoryService)
    {
        _integrationService = categoryService;
    }

    [HttpPost]
    [Route("SendPurchase")]
    public async Task<ActionResult<SendPurchaseViewModelResponse>> SendPurchase([FromBody] SendPurchaseViewModel categoryPayload)
    {
        try
        {
            var category = await _integrationService.SendPurchase(categoryPayload);
            return Ok(category);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
}