namespace ECommerce.IntegrationAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PurchaseController : ControllerBase
{
    private readonly IPurchaseService _purchaseService;

    public PurchaseController(IPurchaseService purchaseService)
    {
        _purchaseService = purchaseService;
    }

    [HttpGet("SendPurchase")]
    public async Task<ActionResult<PurchaseAPIPostResponse>> SendPurchase(PurchaseAPIPostRequest purchaseAPIPostRequest)
    {
        try
        {
            var purchaseResponse = await _purchaseService.Purchase(purchaseAPIPostRequest);
            return Ok(purchaseResponse);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
}
