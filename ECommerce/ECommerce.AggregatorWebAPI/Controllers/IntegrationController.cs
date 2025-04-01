using ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Models.ViewModels;

namespace ECommerce.AggregatorWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class IntegrationController : ControllerBase
{
    private readonly IIntegrationService _categoryService;

    public IntegrationController(IIntegrationService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpPost]
    [Route("SendPurchase")]
    public async Task<ActionResult<SendPurchaseViewModelResponse>> SendPurchase([FromBody] SendPurchaseViewModel categoryPayload)
    {
        try
        {
            var category = await _categoryService.SendPurchase(categoryPayload);
            return Ok(category);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
}