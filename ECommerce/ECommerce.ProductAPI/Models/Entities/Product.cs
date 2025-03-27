namespace ECommerce.ProductAPI.Models.Entities;

public class Product : CommonModelData
{
    public string Description { get; set; }

    [Precision(18, 2)]
    public double Price { get; set; }
}
