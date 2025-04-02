using ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Models.ViewModels.Purchase;

namespace ECommerce.AggregatorWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PurchaseController : ControllerBase
{
    private readonly IPurchaseService _purchaseService;
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;

    public PurchaseController(IPurchaseService purchaseService, IProductService productService, ICategoryService categoryService)
    {
        _purchaseService = purchaseService;
        _categoryService = categoryService;
        _productService = productService;
    }

    [HttpPost]
    [Route("SendPurchase")]
    public async Task<ActionResult<SendPurchaseViewModelResponse>> SendPurchase([FromBody] SendPurchaseViewModel purchasePayload)
    {
        try
        {
            foreach (var item in purchasePayload.itens)
                await _productService.DetailProductById(item.produtoId);

            var purchase = await _purchaseService.SendPurchase(purchasePayload);
            return Ok(purchase);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
}