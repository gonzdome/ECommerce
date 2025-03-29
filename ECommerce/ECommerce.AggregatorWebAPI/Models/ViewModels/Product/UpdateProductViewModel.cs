namespace ECommerce.AggregatorWebAPI.Models.ViewModels.Product;

public class UpdateProductViewModel
{
    public Guid Id { get; set; }

    [MinLength(3)]
    [MaxLength(100)]
    public string Name { get; set; }

    [MinLength(3)]
    [MaxLength(200)]
    public string Description { get; set; }

    public int Stock { get; set; }

    [RegularExpression(@"\d{1,20}(\.\d{1,2})?", ErrorMessage = "Invalid format for price!")]
    public double Price { get; set; }

    public Guid CategoryId { get; set; }
}
