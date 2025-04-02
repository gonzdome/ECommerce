namespace ECommerce.AuthAPI.DTO;

public class CategoryDTO
{
    public Guid Id { get; set; }

    [MinLength(3)]
    [MaxLength(100)]
    public string Name { get; set; }
    public ICollection<User>? Users { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool Active { get; set; } = true;
    public bool Excluded { get; set; } = false;
}
