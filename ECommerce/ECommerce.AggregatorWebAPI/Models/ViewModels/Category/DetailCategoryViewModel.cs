namespace ECommerce.AggregatorWebAPI.Models.ViewModels.Category;

public class DetailCategoryViewModel
{
    public Guid Id { get; set; }

    [MinLength(3)]
    [MaxLength(100)]
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }

    public ICollection<UpdateProductViewModel>? Products { get; set; }
}
