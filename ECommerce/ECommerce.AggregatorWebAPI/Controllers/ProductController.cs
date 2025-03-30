namespace ECommerce.AggregatorWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("GetProducts")]
    public async Task<ActionResult<IEnumerable<GetProductsViewModelResponse>>> GetProducts()
    {
        var product = await _productService.GetProducts();
        return Ok(product);
    }

    [HttpGet("GetProductDetailsById")]
    public async Task<ActionResult<DetailProductViewModelResponse>> GetProductDetailsById([FromQuery] string id)
    {
        var product = await _productService.DetailProductById(id);
        return Ok(product);
    }

    [HttpPost]
    [Route("CreateProduct")]
    public async Task<ActionResult<CreateProductViewModelResponse>> CreateProduct([FromBody] CreateProductViewModel productPayload)
    {
        var product = await _productService.CreateProduct(productPayload);
        return Ok(product);
    }

    [HttpPut("UpdateProductById")]
    public async Task<UpdateProductViewModelResponse> UpdateProductById([FromBody] UpdateProductViewModel productToUpdate)
    {
        var product = await _productService.UpdateProductById(productToUpdate);
        return product;
    }

    [HttpDelete("DeleteProductById")]
    public async Task<ActionResult<DetailProductViewModelResponse>> DeleteProductById([FromQuery] string id)
    {
        var product = await _productService.DeleteProductById(id);
        return Ok(product);
    }

}
