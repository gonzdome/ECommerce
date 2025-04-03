namespace ECommerce.IntegrationAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PurchaseController : ControllerBase
{
    private readonly IIntegrationService _integrationService;
    private readonly IPurchaseService _purchaseService;

    public PurchaseController(IIntegrationService integrationService, IPurchaseService purchaseService)
    {
        _purchaseService = purchaseService;
        _integrationService = integrationService;
    }

    [HttpPost("SendPurchase")]
    public async Task<ActionResult<PurchaseAPIPostResponse>> SendPurchase(SendPurchaseRequest request)
    {
        try
        {
            var integrationDetailsByFlow = await _integrationService.DetailIntegrationByFlow("Purchase");

            var purchaseResponse = await _purchaseService.Purchase(request, integrationDetailsByFlow.Name, integrationDetailsByFlow.Uri);
            return Ok(purchaseResponse);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
}
