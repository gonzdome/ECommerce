using ECommerce.CartAPI.Models.Entities;

namespace ECommerce.CartAPI.DTO.DTOMapping;

public static class CartItemDTOMappingExtension
{
    public static CartItemDTO MapToCartItemDTO(this CartItem cartItem)
    {
        if (cartItem == null)
            return null;

        return new CartItemDTO()
        {
            cartId = cartItem.cartId,
            produtoId = cartItem.produtoId,
            descricao = cartItem.descricao,
            precoUnitario = cartItem.precoUnitario,
            quantidade = cartItem.quantidade,
            CreatedAt = cartItem.CreatedAt,
            UpdatedAt = cartItem.UpdatedAt,
            Active = cartItem.Active,
            Excluded = cartItem.Excluded
        };
    }

    public static CartItem MapToCartItem(this CartItemDTO cartItemDTO)
    {
        if (cartItemDTO == null)
            return null;

        return new CartItem()
        {
            cartId = cartItemDTO.cartId,
            produtoId = cartItemDTO.produtoId,
            descricao = cartItemDTO.descricao,
            precoUnitario = cartItemDTO.precoUnitario,
            quantidade = cartItemDTO.quantidade,
            CreatedAt = cartItemDTO.CreatedAt,
            UpdatedAt = cartItemDTO.UpdatedAt,
            Active = cartItemDTO.Active,
            Excluded = cartItemDTO.Excluded,
        };
    }
}
