namespace ECommerce.ProductAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PurchaseController : ControllerBase
{
    private readonly PurchaseService _purchaseService;

    public PurchaseController(PurchaseService purchaseService)
    {
        _purchaseService = purchaseService;
    }

    [HttpGet("Purchases")]
    public async Task<ActionResult<IEnumerable<Purchase>>> Purchases()
    {
        var purchase = _purchaseService.Purchases();
        return Ok(purchase);
    }

    [HttpGet("{id:string}", Name = "PurchaseDetailsById")]
    public async Task<ActionResult<Purchase>> PurchaseDetailsById(string id)
    {
        var purchase = _purchaseService.Purchase(id);
        return Ok(purchase);
    }

    [HttpPost]
    [Route("Purchase")]
    public ActionResult<Purchase> Purchase(Purchase purchasePayload)
    {
        var purchase = _purchaseService.Purchase(purchasePayload);
        return Ok(purchase);
    }

    [HttpPut("{id:string}", Name = "PurchaseById")]
    public ActionResult<Purchase> PurchaseById(string id, Purchase purchaseToUpdate)
    {
        var purchase = _purchaseService.Purchase(id, purchaseToUpdate);
        return Ok(purchase);
    }

    [HttpDelete("{id:string}", Name = "PurchaseById")]
    public ActionResult<Purchase> PurchaseById(string id)
    {
        var purchase = _purchaseService.Purchase(id);
        return Ok(purchase);
    }

}
