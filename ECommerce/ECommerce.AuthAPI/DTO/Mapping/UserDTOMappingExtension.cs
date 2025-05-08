using ECommerce.AuthAPI.Models.Entities;

namespace ECommerce.AuthAPI.DTO.DTOMapping;

public static class UserDTOMappingExtension
{
    public static UserDTO MapToUserDTO(this User user)
    {
        if (user == null)
            return null;

        return new UserDTO()
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            Document = user.Document,
            Password = user.Password,
            OldPassword = user.OldPassword,
            CategoryId = user.CategoryId,
            CreatedAt = user.CreatedAt,
            UpdatedAt = user.UpdatedAt,
            Active = user.Active,
            Excluded = user.Excluded,
        };
    }

    public static User MapToUser(this UserDTO userDTO)
    {
        if (userDTO == null)
            return null;

        return new User()
        {
            Id = userDTO.Id,
            Name = userDTO.Name,
            Email = userDTO.Email,
            Document = userDTO.Document,
            Password = userDTO.Password,
            OldPassword = userDTO.OldPassword,
            CategoryId = userDTO.CategoryId,
            CreatedAt = userDTO.CreatedAt,
            UpdatedAt = userDTO.UpdatedAt,
            Active = userDTO.Active,
            Excluded = userDTO.Excluded,
        };
    }
}
