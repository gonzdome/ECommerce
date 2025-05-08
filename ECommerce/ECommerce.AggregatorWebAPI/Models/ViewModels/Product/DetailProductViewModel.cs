using Microsoft.EntityFrameworkCore;

namespace ECommerce.AggregatorWebAPI.Models.ViewModels.Product;

public class DetailProductViewModel
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
    public decimal Price { get; set; }

    public Guid CategoryId { get; set; }

    public DateTime CreatedAt { get; set; }
}
