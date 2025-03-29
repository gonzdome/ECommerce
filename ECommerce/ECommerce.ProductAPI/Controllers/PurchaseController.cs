namespace ECommerce.ProductAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PurchaseController : ControllerBase
{
    private readonly IPurchaseService _purchaseService;

    public PurchaseController(IPurchaseService purchaseService)
    {
        _purchaseService = purchaseService;
    }

    [HttpGet("GetPurchases")]
    public async Task<ActionResult<IEnumerable<PurchaseDTO>>> GetPurchases()
    {
        var purchase = _purchaseService.GetPurchases();
        return Ok(purchase);
    }

    [HttpGet("{id}", Name = "PurchaseDetailsById")]
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

    [HttpPut("{id}", Name = "UpdatePurchaseById")]
    public ActionResult<PurchaseDTO> UpdatePurchaseById(string id, PurchaseDTO purchaseToUpdate)
    {
        var purchase = _purchaseService.UpdatePurchaseById(id, purchaseToUpdate);
        return Ok(purchase);
    }

    [HttpDelete("{id}", Name = "DeletePurchaseById")]
    public ActionResult<PurchaseDTO> DeletePurchaseById(string id)
    {
        var purchase = _purchaseService.DeletePurchaseById(id);
        return Ok(purchase);
    }

}
