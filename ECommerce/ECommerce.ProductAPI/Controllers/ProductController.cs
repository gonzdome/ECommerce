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
        try
        {
            var product = await _productService.GetProducts();
            return Ok(product);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpGet("GetProductDetailsById")]
    public async Task<ActionResult<ProductDTO>> GetProductDetailsById([FromQuery] string id)
    {
        try
        {
            var product = await _productService.DetailProductById(id);
            return Ok(product);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpPost]
    [Route("CreateProduct")]
    public async Task<ActionResult<ProductDTO>> CreateProduct(ProductDTO productPayload)
    {
        try
        {
            var product = await _productService.CreateProduct(productPayload);
            return Ok(product);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpPut("UpdateProductById")]
    public async Task<ActionResult<ProductDTO>> UpdateProductById(ProductDTO productToUpdate)
    {
        try
        {
            var product = await _productService.UpdateProductById(productToUpdate);
            return product;
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteProductById")]
    public async Task<ActionResult<ProductDTO>> DeleteProductById([FromQuery] string id)
    {
        try
        {
            var product = await _productService.DeleteProductById(id);
            return Ok(product);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
}
