namespace ECommerce.ProductAPI.DTO;

public class PurchaseDTO
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public Guid ProductId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool Active { get; set; }
    public bool Excluded { get; set; }
}
