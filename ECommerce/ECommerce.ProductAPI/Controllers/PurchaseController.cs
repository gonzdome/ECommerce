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

    [HttpGet("GetPurchases")]
    public async Task<ActionResult<IEnumerable<PurchaseDTO>>> Purchases()
    {
        var purchase = _purchaseService.GetPurchases();
        return Ok(purchase);
    }

    [HttpGet("{id:string}", Name = "PurchaseDetailsById")]
    public async Task<ActionResult<PurchaseDTO>> PurchaseDetailsById(string id)
    {
        var purchase = _purchaseService.DeletePurchaseById(id);
        return Ok(purchase);
    }

    [HttpPost]
    [Route("CreatePurchase")]
    public ActionResult<PurchaseDTO> CreatePurchase(PurchaseDTO purchasePayload)
    {
        var purchase = _purchaseService.CreatePurchase(purchasePayload);
        return Ok(purchase);
    }

    [HttpPut("{id:string}", Name = "UpdatePurchaseById")]
    public ActionResult<PurchaseDTO> UpdatePurchaseById(string id, PurchaseDTO purchaseToUpdate)
    {
        var purchase = _purchaseService.UpdatePurchaseById(id, purchaseToUpdate);
        return Ok(purchase);
    }

    [HttpDelete("{id:string}", Name = "DeletePurchaseById")]
    public ActionResult<PurchaseDTO> DeletePurchaseById(string id)
    {
        var purchase = _purchaseService.DeletePurchaseById(id);
        return Ok(purchase);
    }

}
