using ECommerce.ProductAPI.Models.Entities;

namespace ECommerce.ProductAPI.DTO.DTOMapping;

public static class ProductDTOMappingExtension
{
    public static ProductDTO MapToProductDTO(this Product product)
    {
        if (product == null)
            return null;

        return new ProductDTO()
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Stock = product.Stock,
            Price = product.Price,
            CategoryId = product.CategoryId,
            CreatedAt = product.CreatedAt,
            UpdatedAt = product.UpdatedAt,
            Active = product.Active,
            Excluded = product.Excluded,
        };
    }

    public static Product MapToProduct(this ProductDTO productDTO)
    {
        if (productDTO == null)
            return null;

        return new Product()
        {
            Id = productDTO.Id,
            Name = productDTO.Name,
            Description = productDTO.Description,
            Stock = productDTO.Stock,
            Price = productDTO.Price,
            CategoryId = productDTO.CategoryId,
            CreatedAt = productDTO.CreatedAt,
            UpdatedAt = productDTO.UpdatedAt,
            Active = productDTO.Active,
            Excluded = productDTO.Excluded,
        };
    }
}
