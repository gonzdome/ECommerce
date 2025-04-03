namespace ECommerce.CartAPI.DTO;

public class CartDTO
{
    public Guid identificador { get; set; }
    public DateTime dataVenda { get; set; }
    public Guid clienteId { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool Active { get; set; } = true;
    public bool Excluded { get; set; } = false;
}
