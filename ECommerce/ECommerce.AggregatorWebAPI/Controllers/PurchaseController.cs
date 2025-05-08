using ECommerce.AggregatorWebAPI.Gateways.IntegrationAPI.Models.ViewModels.Purchase;

namespace ECommerce.AggregatorWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PurchaseController : ControllerBase
{
    private readonly IPurchaseService _purchaseService;
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;
    private readonly IUserService _userService;
    private readonly IUserCategoryService _userCategoryService;

    public PurchaseController(IPurchaseService purchaseService, IProductService productService, ICategoryService categoryService, IUserService userService, IUserCategoryService userCategoryService)
    {
        _purchaseService = purchaseService;
        _categoryService = categoryService;
        _productService = productService;
        _userService = userService;
        _userCategoryService = userCategoryService;

    }

    [HttpPost]
    [Route("SendPurchase")]
    public async Task<ActionResult<SendPurchaseViewModelResponse>> SendPurchase([FromBody] SendPurchaseViewModel purchasePayload)
    {
        try
        {
            foreach (var item in purchasePayload.itens)
            {
                var product = await _productService.DetailProductById(item.produtoId);
                item.produtoId = product.Data.Id.ToString();
                item.precoUnitario = product.Data.Price;
                item.descricao = product.Data.Description;
            }

            var user = await _userService.DetailUserById(purchasePayload.cliente.clienteId);
            var userCategory = await _userCategoryService.DetailUserCategoryById(user.Data.CategoryId.ToString());

            purchasePayload.cliente.nome = user.Data.Name;
            purchasePayload.cliente.cpf = user.Data.Document;
            purchasePayload.cliente.categoria = userCategory.Data.Name;

            purchasePayload.dataVenda = DateTime.UtcNow.ToString();

            var purchase = await _purchaseService.SendPurchase(purchasePayload);
            return Ok(purchase);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
}