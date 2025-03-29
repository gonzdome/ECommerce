namespace ECommerce.ProductAPI.DTO;

public class ProductDTO
{
    public Guid Id { get; set; }

    [MinLength(3)]
    [MaxLength(100)]
    public string Name { get; set; }

    [MinLength(3)]
    [MaxLength(200)]
    public string Description { get; set; }

    public int Stock { get; set; }

    [Precision(18, 2)]
    public double Price { get; set; }

    public Guid CategoryId { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool Active { get; set; }
    public bool Excluded { get; set; }
}
