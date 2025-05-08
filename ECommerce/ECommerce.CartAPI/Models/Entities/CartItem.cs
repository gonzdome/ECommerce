using ECommerce.ProductAPI.Models.Entities;

namespace ECommerce.CartAPI.Models.Entities;

public class CartItem : CommonModelData
{
    public Guid produtoId { get; set; }
    public string descricao { get; set; }

    [Precision(18, 1)]
    public decimal quantidade { get; set; }

    [Precision(18, 2)]
    public decimal precoUnitario { get; set; }
    public Guid cartId { get; set; }

}
