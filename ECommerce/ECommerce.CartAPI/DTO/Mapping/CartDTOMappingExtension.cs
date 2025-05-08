using ECommerce.CartAPI.Models.Entities;

namespace ECommerce.CartAPI.DTO.DTOMapping;

public static class CartDTOMappingExtension
{
    public static CartDTO MapToCartDTO(this Cart cart)
    {
        if (cart == null)
            return null;

        return new CartDTO()
        {
            clienteId = cart.clienteId,
            dataVenda = cart.dataVenda,
            identificador = cart.identificador,
            CreatedAt = cart.CreatedAt,
            UpdatedAt = cart.UpdatedAt,
            Active = cart.Active,
            Excluded = cart.Excluded,
        };
    }

    public static Cart MapToCart(this CartDTO cartDTO)
    {
        if (cartDTO == null)
            return null;

        return new Cart()
        {
            clienteId = cartDTO.clienteId,
            dataVenda = cartDTO.dataVenda,
            identificador = cartDTO.identificador,
            CreatedAt = cartDTO.CreatedAt,
            UpdatedAt = cartDTO.UpdatedAt,
            Active = cartDTO.Active,
            Excluded = cartDTO.Excluded,
        };
    }
}
