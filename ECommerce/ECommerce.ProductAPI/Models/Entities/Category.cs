namespace ECommerce.ProductAPI.Models.Entities;

public class Category : CommonModelData
{
    [MinLength(3)]
    [MaxLength(100)]
    public string Name { get; set; }
    public ICollection<Product>? Products { get; set; }
}
