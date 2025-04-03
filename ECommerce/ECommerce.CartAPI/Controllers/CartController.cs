namespace ECommerce.CartAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CartController : ControllerBase
{
    private readonly ICartService _cartService;

    public CartController(ICartService cartService)
    {
        _cartService = cartService;
    }

    [HttpGet("GetCarts")]
    public async Task<ActionResult<IEnumerable<CartDTO>>> GetCarts()
    {
        try
        {
            var cart = await _cartService.GetCarts();
            return Ok(cart);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpGet("GetCartDetailsById")]
    public async Task<ActionResult<CartDTO>> GetCartDetailsById([FromQuery] string id)
    {
        try
        {
            var cart = await _cartService.DetailCartById(id);
            return Ok(cart);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpPost]
    [Route("CreateCart")]
    public async Task<ActionResult<CartDTO>> CreateCart(CartDTO cartPayload)
    {
        try
        {
            var cart = await _cartService.CreateCart(cartPayload);
            return Ok(cart);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpPut("UpdateCartById")]
    public async Task<ActionResult<CartDTO>> UpdateCartById(CartDTO cartToUpdate)
    {
        try
        {
            var cart = await _cartService.UpdateCartById(cartToUpdate);
            return cart;
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("DeleteCartById")]
    public async Task<ActionResult<CartDTO>> DeleteCartById([FromQuery] string id)
    {
        try
        {
            var cart = await _cartService.DeleteCartById(id);
            return Ok(cart);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
}
