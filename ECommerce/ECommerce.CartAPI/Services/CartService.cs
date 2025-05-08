namespace ECommerce.CartAPI.Services;

public class CartService : ICartService
{
    private readonly IUnitOfWork _unitOfWork;

    public CartService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<CartDTO> DetailCartById(string id)
    {
        var cart = await GetAndReturnCart(id);

        return cart.MapToCartDTO();
    }

    public async Task<IEnumerable<CartDTO>> GetCarts()
    {
        IEnumerable<Cart> carts = (await _unitOfWork.CartRepository.GetAll()).Where(p => !p.Excluded && p.Active);

        var cartsMapped = carts.Select(p => p.MapToCartDTO());

        return cartsMapped;
    }

    public async Task<CartDTO> CreateCart(CartDTO cartToCreate)
    {
        Cart mappedToCart = cartToCreate.MapToCart();

        mappedToCart.CreatedAt = DateTime.Now;
        mappedToCart.UpdatedAt = DateTime.Now;

        var cartCreated = await _unitOfWork.CartRepository.Create(mappedToCart);
        await _unitOfWork.Commit();

        return cartCreated.MapToCartDTO();
    }

    public async Task<CartDTO> UpdateCartById(CartDTO cartToUpdate)
    {
        await GetAndReturnCart(cartToUpdate.identificador.ToString());

        cartToUpdate.UpdatedAt = DateTime.Now;

        var mappedCart = cartToUpdate.MapToCart();

        await _unitOfWork.CartRepository.Update(mappedCart);
        await _unitOfWork.Commit();

        return mappedCart.MapToCartDTO();
    }

    public async Task<CartDTO> DeleteCartById(string id)
    {
        var foundCart = await GetAndReturnCart(id);
        
        foundCart.Excluded = true;

        await _unitOfWork.CartRepository.Update(foundCart);
        await _unitOfWork.Commit();

        return foundCart.MapToCartDTO();
    }

    private async Task<Cart> GetAndReturnCart(string id)
    {
        var cart = await _unitOfWork.CartRepository.Details(p => p.identificador == Guid.Parse(id) && !p.Excluded && p.Active);
        if (cart == null)
            throw new Exception($"Cart with id {id} not found!");

        return cart;
    }
}
