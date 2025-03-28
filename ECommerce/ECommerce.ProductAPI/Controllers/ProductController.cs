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

    [HttpGet("{id:string}", Name = "GetProductDetailsById")]
    public async Task<ActionResult<ProductDTO>> GetProductDetailsById(string id)
    {
        var product = _productService.DetailProduct(id);
        return Ok(product);
    }

    [HttpPost]
    [Route("CreateProduct")]
    public ActionResult<ProductDTO> CreateProduct(ProductDTO productPayload)
    {
        var product = _productService.CreateProduct(productPayload);
        return Ok(product);
    }

    [HttpPut("{id:string}", Name = "UpdateProductById")]
    public ActionResult<ProductDTO> UpdateProductById(string id, ProductDTO productToUpdate)
    {
        var product = _productService.UpdateProductById(id, productToUpdate);
        return Ok(product);
    }

    [HttpDelete("{id:string}", Name = "DeleteProductById")]
    public ActionResult<ProductDTO> DeleteProductById(string id)
    {
        var product = _productService.DeleteProductById(id);
        return Ok(product);
    }

}
