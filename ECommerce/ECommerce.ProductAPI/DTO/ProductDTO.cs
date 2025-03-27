namespace ECommerce.ProductAPI.DTO;

public class ProductDTO
{
    public Guid Id { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool Active { get; set; }
    public bool Excluded { get; set; }
}
