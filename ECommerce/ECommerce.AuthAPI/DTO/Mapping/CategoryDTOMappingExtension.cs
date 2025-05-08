namespace ECommerce.AuthAPI.DTO.DTOMapping;

public static class CategoryDTOMappingExtension
{
    public static CategoryDTO MapToCategoryDTO(this Category category)
    {
        if (category == null)
            return null;

        return new CategoryDTO()
        {
            Id = category.Id,
            Name = category.Name,
            Users = category.Users,
            CreatedAt = category.CreatedAt,
            UpdatedAt = category.UpdatedAt,
            Active = category.Active,
            Excluded = category.Excluded,
        };
    }

    public static Category MapToCategory(this CategoryDTO categoryDTO)
    {
        if (categoryDTO == null)
            return null;

        return new Category()
        {
            Id = categoryDTO.Id,
            Name = categoryDTO.Name,
            Users = categoryDTO.Users,
            CreatedAt = categoryDTO.CreatedAt,
            UpdatedAt = categoryDTO.UpdatedAt,
            Active = categoryDTO.Active,
            Excluded = categoryDTO.Excluded,
        };
    }
}
