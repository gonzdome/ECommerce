namespace ECommerce.ProductAPI.Controllers;

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
    public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
    {
        var product = _productService.GetProducts();
        return Ok(product);
    }

    [HttpGet("{id}", Name = "GetProductDetailsById")]
    public async Task<ActionResult<ProductDTO>> GetProductDetailsById(string id)
    {
        var product = _productService.DetailProductById(id);
        return Ok(product);
    }

    [HttpPost]
    [Route("CreateProduct")]
    public async Task<ActionResult<ProductDTO>> CreateProduct(ProductDTO productPayload)
    {
        var product = _productService.CreateProduct(productPayload);
        return Ok(product);
    }

    [HttpPut("{id}", Name = "UpdateProductById")]
    public async Task<ActionResult<ProductDTO>> UpdateProductById(string id, ProductDTO productToUpdate)
    {
        var product = _productService.UpdateProductById(id, productToUpdate);
        return Ok(product);
    }

    [HttpDelete("{id}", Name = "DeleteProductById")]
    public async Task<ActionResult<ProductDTO>> DeleteProductById(string id)
    {
        var product = _productService.DeleteProductById(id);
        return Ok(product);
    }

}
