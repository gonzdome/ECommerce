namespace ECommerce.IntegrationAPI.DTO;

public class IntegrationDTO
{
    public Guid Id { get; set; }

    [MinLength(3)]
    [MaxLength(100)]
    public string Name { get; set; }

    [MinLength(3)]
    [MaxLength(300)]
    public string Flow { get; set; }

    [MinLength(3)]
    [MaxLength(500)]
    public string Uri { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool Active { get; set; } = true;
    public bool Excluded { get; set; } = false;
}
