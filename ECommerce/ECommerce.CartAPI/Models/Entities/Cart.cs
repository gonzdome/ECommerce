using ECommerce.ProductAPI.Models.Entities;

namespace ECommerce.CartAPI.Models.Entities;

public class Cart : CommonModelData
{
    public Guid identificador { get; set; }
    public DateTime dataVenda { get; set; }
    public Guid clienteId { get; set; }    
}
