namespace ECommerce.CartAPI.DTO;

public class CartItemDTO
{
    public Guid produtoId { get; set; }
    public string descricao { get; set; }

    [Precision(18, 1)]
    public decimal quantidade { get; set; }

    [Precision(18, 2)]
    public decimal precoUnitario { get; set; }
    public Guid cartId { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool Active { get; set; } = true;
    public bool Excluded { get; set; } = false;
}
