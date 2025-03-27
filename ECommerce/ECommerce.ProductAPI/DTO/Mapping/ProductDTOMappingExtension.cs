namespace ECommerce.ProductAPI.DTO.DTOMapping;

public static class ProductDTOMappingExtension
{
    public static ProductDTO MapToProductDTO(this Product category)
    {
        if (category == null)
            return null;

        return new ProductDTO()
        {
            Id = category.Id,
            Description = category.Description,
            Price = category.Price,
            CreatedAt = category.CreatedAt,
            UpdatedAt = category.UpdatedAt,
            Active = category.Active,
            Excluded = category.Excluded,
        };
    }

    public static Product MapToProduct(this ProductDTO categoryDTO)
    {
        if (categoryDTO == null)
            return null;

        return new Product()
        {
            Id = categoryDTO.Id,
            Description = categoryDTO.Description,
            Price = categoryDTO.Price,
            CreatedAt = categoryDTO.CreatedAt,
            UpdatedAt = categoryDTO.UpdatedAt,
            Active = categoryDTO.Active,
            Excluded = categoryDTO.Excluded,
        };
    }
}
