namespace ECommerce.AuthAPI.DTO;

public class UserDTO
{
    public Guid Id { get; set; }

    [MinLength(3)]
    [MaxLength(100)]
    public string Name { get; set; }

    [MinLength(3)]
    [MaxLength(200)]
    public string Email { get; set; }
    public string Document { get; set; }
    public string Password { get; set; }
    public string OldPassword { get; set; }

    public Guid CategoryId { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool Active { get; set; } = true;
    public bool Excluded { get; set; } = false;
}
