namespace ECommerce.CartAPI.Services.Interfaces;

public interface ICartService
{
    public Task<IEnumerable<CartDTO>> GetCarts();
    public Task<CartDTO> DetailCartById(string id);
    public Task<CartDTO> CreateCart(CartDTO product);
    public Task<CartDTO> UpdateCartById(CartDTO product);
    public Task<CartDTO> DeleteCartById(string id);
}
