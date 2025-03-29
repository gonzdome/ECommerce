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
    public async Task<ActionResult<IEnumerable<GetProductsViewModel>>> GetProducts()
    {
        var product = await _productService.GetProducts();
        return Ok(product);
    }

    [HttpGet("{id}", Name = "GetProductDetailsById")]
    public async Task<ActionResult<DetailProductViewModel>> GetProductDetailsById(string id)
    {
        var product = await _productService.DetailProduct(id);
        return Ok(product);
    }

    [HttpPost]
    [Route("CreateProduct")]
    public async Task<ActionResult<CreateProductViewModel>> CreateProduct(CreateProductViewModel productPayload)
    {
        var product = await _productService.CreateProduct(productPayload);
        return Ok(product);
    }

    [HttpPut("{id}", Name = "UpdateProductById")]
    public async Task<ActionResult<UpdateProductViewModel>> UpdateProductById(string id, UpdateProductViewModel productToUpdate)
    {
        var product = await _productService.UpdateProductById(id, productToUpdate);
        return Ok(product);
    }

    [HttpDelete("{id}", Name = "DeleteProductById")]
    public async Task<ActionResult<DetailProductViewModel>> DeleteProductById(string id)
    {
        var product = await _productService.DeleteProductById(id);
        return Ok(product);
    }

}
